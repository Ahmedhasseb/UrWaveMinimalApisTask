using Microsoft.AspNetCore.Mvc;
using UrWave.Data.dbContext;
using UrWave.Data.Model;
using UrWave.Featuers.Product.DTO.ProductDTO;
using FluentValidation;
using FluentValidation.Results;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using UrWave.Featuers.Product.Vailditors;
using Microsoft.EntityFrameworkCore;
using UrWave.Data.Model.enums;
using UrWave.Featuers.Product.EndPoints;
using UrWave.Featuers.Product.Interface;

namespace UrWave
{
    public static class MapProduct
    {
        public static void MapProductEndPoints(this IEndpointRouteBuilder app)
        {
            var products = app.MapGroup("/api/Products").DisableAntiforgery();
            products.MapPost("/CreateProduct", async ([FromForm] AddOrUpdateProductDto RequestDto,
                 DbContexts _dbContexts,
                 IPhoto _Cloudinary) =>
            {
                var validationResult = new ProductVailditor();
                var Result = validationResult.Validate(RequestDto);
                if (!Result.IsValid)
                    return Results.BadRequest(Result.Errors);

                var imagePath = await _Cloudinary.UploadImageAsync(RequestDto.ImageUrl);
                var AddProduct = new Product()
                {
                    Name = RequestDto.Name,
                    Description = RequestDto.Description,
                    Price = RequestDto.Price,
                    ImageUrl=imagePath.ToString(),
                };

                await _dbContexts.products.AddAsync(AddProduct);
                await _dbContexts.SaveChangesAsync();
                return Results.Ok(new { Ok = 200, Message = "Add Product Successfly" });
            });
            products.MapGet("/GetAllProducts", async (DbContexts _Contexts,string? Search,decimal? MinPrice=null,decimal? MaxPrice=null) =>
            {

                var query = _Contexts.products.Where(i => i.states != Status.Deleted);
                if (!string.IsNullOrEmpty(Search))
                {
                    query = query.Where(p => p.Name.Contains(Search));
                }
                if (MinPrice.HasValue&& MinPrice > 0)
                {
                    query = query.Where(p => p.Price >= MinPrice.Value);
                }
                if (MaxPrice.HasValue&& MaxPrice > 0)
                {
                    query = query.Where(p => p.Price <= MaxPrice.Value);
                }
             
                var MapToDTOProduct = query.Select(i => new ProductDTOS
                {
                    Id = i.Id,
                    Description = i.Description,
                    Name = i.Name,
                    Price = i.Price,
                    Image=i.ImageUrl,
                    CreateAt=i.CreateDate
                    
                    
                }).ToList();

                return Results.Ok(MapToDTOProduct);

            });
            products.MapGet("/GetProductByid/{id:int}", async (int id, DbContexts dbContexts) =>
            {
                var product = await dbContexts.products.FindAsync(id);
                if (product == null)
                    return Results.NotFound();
                var productDto = new ProductDTOS
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                     Image=product.ImageUrl,
                     CreateAt=product.CreateDate

                };
                return Results.Ok(productDto);
            });
            products.MapPut("/Update/{id:int}", async (int id, DbContexts dbContexts,[FromBody] AddOrUpdateProductDto Request) =>
            {
                var product = await dbContexts.products.FindAsync(id);
                var validationResult = new ProductVailditor();
                var Result = validationResult.Validate(Request);
                if (!Result.IsValid)
                    return Results.BadRequest(Result.Errors);
                product.Name = Request.Name;
                product.Description = Request.Description;
                product.Price = Request.Price;
                dbContexts.products.Update(product);
                await dbContexts.SaveChangesAsync();
                return Results.Ok(new { Ok = 200, Message = "Update Product Successfuly" });
            });
            products.MapDelete("/Delete/{id:int}", async (int id, DbContexts dbContexts) =>
            {
                var product = await dbContexts.products.FindAsync(id);
                if (product == null)
                    return Results.NotFound();
                product.states = Status.Deleted;
                dbContexts.products.Update(product);
                await dbContexts.SaveChangesAsync();
                return Results.Ok(new { Ok = 200, Message = $"Delete Product Successfuly{product.Id}" });
            });

        }
    }
    }

