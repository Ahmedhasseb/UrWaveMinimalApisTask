using Microsoft.EntityFrameworkCore;
using UrWave.Data.DataSeeding;
using UrWave.Data.Model;

namespace UrWave.Data.dbContext
{
    public class DbContexts : DbContext
    {
        public DbContexts(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.SeedProduct();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> products { get; set; }
    }
}
