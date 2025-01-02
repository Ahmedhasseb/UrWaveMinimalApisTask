
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Text.Json.Serialization;
using UrWave.Data.dbContext;
using UrWave.Featuers.Product.DTO.ProductDTO;
using UrWave.Featuers.Product.EndPoints;
using UrWave.Featuers.Product.Interface;
using UrWave.MiddelWare;



namespace UrWave
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            }); ;
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IPhoto,CloudinaryHelper>();
            builder.Services.AddControllers().AddFluentValidation(i =>
            {
                i.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            });
        
            builder.Services.AddDbContext<DbContexts>(options =>
          options.UseLazyLoadingProxies()
          .UseSqlServer(builder.Configuration.GetConnectionString("MyDatabase")));
           
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            
            app.UseStaticFiles();
            app.UseHttpsRedirection();

            app.UseCors(builder => builder
                 .AllowAnyMethod()
                 .AllowAnyHeader()
                 .SetIsOriginAllowed((host) => true) // Allow any origin for testing; tighten this in production
                 .AllowCredentials());
            app.UseRouting();

          
          
            app.UseAuthorization();

            app.MapProductEndPoints();

            app.UseMiddleware<ErrorHandalingMiddleWare>();
            app.MapControllers();

            app.Run();
        }
    }
}
