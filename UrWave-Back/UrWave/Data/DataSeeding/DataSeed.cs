using Microsoft.EntityFrameworkCore;
using UrWave.Data.Model;

namespace UrWave.Data.DataSeeding
{
    public static class DataSeed
    {
        public static void SeedProduct(this ModelBuilder builder)
        {
            builder.Entity<Product>().HasData
                (
         new Product { Id = 1, Name = "iPhone 13", Description = "Apple iPhone 13 with A15 Bionic chip", Price = 799m,ImageUrl= "http://res.cloudinary.com/dcan8prl1/image/upload/v1725289186/ilqyuyvu88l5mvetolks.jpg" },
         new Product { Id = 2, Name = "iPhone 13 Pro",  Description = "Apple iPhone 13 Pro with triple camera system", Price = 999m, ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1725289234/big9pzjorkqgd2ktjk0r.jpg" },
         new Product { Id = 3, Name = "iPhone 12",  Description = "Apple iPhone 12 with A14 Bionic chip",  Price = 699m, ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1725289271/bh23hfxzvkbgqdvctjm6.jpg" },
         new Product { Id = 4, Name = "iPhone 12 Pro", Description = "Apple iPhone 12 Pro with LiDAR scanner",  Price = 899m, ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1725289297/lb9pd49w7cjgy4lihxrs.jpg" },
         new Product { Id = 5, Name = "iPhone SE",  Description = "Apple iPhone SE with A13 Bionic chip",  Price = 399m, ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1726419551/htqp0xfkwe3ami3nprpm.jpg" },

         // Samsung Products   
         new Product { Id = 6, Name = "Samsung Galaxy S21", Description = "Samsung Galaxy S21 with Exynos 2100", Price = 799m, ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1726419375/ujawtrymxj1n07gpezci.jpg" },
         new Product { Id = 7, Name = "Samsung Galaxy S21 Ultra",  Description = "Samsung Galaxy S21 Ultra with 108MP camera", Price = 1199m, ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1726419397/cx2le61pqegbcwl0o9hg.jpg" },
         new Product { Id = 8, Name = "Samsung Galaxy Note 20", Description = "Samsung Galaxy Note 20 with S Pen", Price = 999m, ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1726419420/eptsgp47br7xnosezhuq.jpg" },
         new Product { Id = 9, Name = "Samsung Galaxy A52",  Description = "Samsung Galaxy A52 with Snapdragon 720G", Price = 399m, ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1726419447/r4gxty3nd2jycprjk44z.jpg" },
         new Product { Id = 10, Name = "Samsung Galaxy Z Fold 3", Description = "Samsung Galaxy Z Fold 3 with foldable display",  Price = 1799m, ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1726419472/ypualvh9yyfurcpgyutn.jpg" },

         // Huawei Products   
         new Product { Id = 11, Name = "Huawei P40",  Description = "Huawei P40 with Kirin 990 5G", Price = 699m, ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1727094367/qecgksj5wgqip1uc7rdq.jpg" },
         new Product { Id = 12, Name = "Huawei Mate 40 Pro", Description = "Huawei Mate 40 Pro with Kirin 9000 5G",  Price = 1099m, ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1727094403/tps9v5i5ldo9vhsvlyph.jpg" },
         new Product { Id = 13, Name = "Huawei Nova 7i",  Description = "Huawei Nova 7i with Kirin 810",  Price = 299m, ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1727094423/ddes01kvtshludrselb9.jpg" },
         new Product { Id = 14, Name = "Huawei Y9a", Description = "Huawei Y9a with MediaTek Helio G80",  Price = 249m, ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1727094451/z0tp2io09zlv0j0ph41g.jpg" },
         new Product { Id = 15, Name = "Huawei P30 Pro",  Description = "Huawei P30 Pro with Leica quad camera", Price = 599m, ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1727095166/tyflasqpdnvol5mi6czm.jpg" }

                );

        }
    }
}
