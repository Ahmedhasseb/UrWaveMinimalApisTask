﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UrWave.Data.dbContext;

#nullable disable

namespace UrWave.Migrations
{
    [DbContext(typeof(DbContexts))]
    [Migration("20241231133347_AddData")]
    partial class AddData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UrWave.Data.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("states")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1136),
                            Description = "Apple iPhone 13 with A15 Bionic chip",
                            ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1725289186/ilqyuyvu88l5mvetolks.jpg",
                            Name = "iPhone 13",
                            Price = 799m,
                            states = 0
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1187),
                            Description = "Apple iPhone 13 Pro with triple camera system",
                            ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1725289234/big9pzjorkqgd2ktjk0r.jpg",
                            Name = "iPhone 13 Pro",
                            Price = 999m,
                            states = 0
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1191),
                            Description = "Apple iPhone 12 with A14 Bionic chip",
                            ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1725289271/bh23hfxzvkbgqdvctjm6.jpg",
                            Name = "iPhone 12",
                            Price = 699m,
                            states = 0
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1195),
                            Description = "Apple iPhone 12 Pro with LiDAR scanner",
                            ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1725289297/lb9pd49w7cjgy4lihxrs.jpg",
                            Name = "iPhone 12 Pro",
                            Price = 899m,
                            states = 0
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1199),
                            Description = "Apple iPhone SE with A13 Bionic chip",
                            ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1726419551/htqp0xfkwe3ami3nprpm.jpg",
                            Name = "iPhone SE",
                            Price = 399m,
                            states = 0
                        },
                        new
                        {
                            Id = 6,
                            CreateDate = new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1203),
                            Description = "Samsung Galaxy S21 with Exynos 2100",
                            ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1726419375/ujawtrymxj1n07gpezci.jpg",
                            Name = "Samsung Galaxy S21",
                            Price = 799m,
                            states = 0
                        },
                        new
                        {
                            Id = 7,
                            CreateDate = new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1207),
                            Description = "Samsung Galaxy S21 Ultra with 108MP camera",
                            ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1726419397/cx2le61pqegbcwl0o9hg.jpg",
                            Name = "Samsung Galaxy S21 Ultra",
                            Price = 1199m,
                            states = 0
                        },
                        new
                        {
                            Id = 8,
                            CreateDate = new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1210),
                            Description = "Samsung Galaxy Note 20 with S Pen",
                            ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1726419420/eptsgp47br7xnosezhuq.jpg",
                            Name = "Samsung Galaxy Note 20",
                            Price = 999m,
                            states = 0
                        },
                        new
                        {
                            Id = 9,
                            CreateDate = new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1213),
                            Description = "Samsung Galaxy A52 with Snapdragon 720G",
                            ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1726419447/r4gxty3nd2jycprjk44z.jpg",
                            Name = "Samsung Galaxy A52",
                            Price = 399m,
                            states = 0
                        },
                        new
                        {
                            Id = 10,
                            CreateDate = new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1216),
                            Description = "Samsung Galaxy Z Fold 3 with foldable display",
                            ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1726419472/ypualvh9yyfurcpgyutn.jpg",
                            Name = "Samsung Galaxy Z Fold 3",
                            Price = 1799m,
                            states = 0
                        },
                        new
                        {
                            Id = 11,
                            CreateDate = new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1219),
                            Description = "Huawei P40 with Kirin 990 5G",
                            ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1727094367/qecgksj5wgqip1uc7rdq.jpg",
                            Name = "Huawei P40",
                            Price = 699m,
                            states = 0
                        },
                        new
                        {
                            Id = 12,
                            CreateDate = new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1222),
                            Description = "Huawei Mate 40 Pro with Kirin 9000 5G",
                            ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1727094403/tps9v5i5ldo9vhsvlyph.jpg",
                            Name = "Huawei Mate 40 Pro",
                            Price = 1099m,
                            states = 0
                        },
                        new
                        {
                            Id = 13,
                            CreateDate = new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1225),
                            Description = "Huawei Nova 7i with Kirin 810",
                            ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1727094423/ddes01kvtshludrselb9.jpg",
                            Name = "Huawei Nova 7i",
                            Price = 299m,
                            states = 0
                        },
                        new
                        {
                            Id = 14,
                            CreateDate = new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1228),
                            Description = "Huawei Y9a with MediaTek Helio G80",
                            ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1727094451/z0tp2io09zlv0j0ph41g.jpg",
                            Name = "Huawei Y9a",
                            Price = 249m,
                            states = 0
                        },
                        new
                        {
                            Id = 15,
                            CreateDate = new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1230),
                            Description = "Huawei P30 Pro with Leica quad camera",
                            ImageUrl = "http://res.cloudinary.com/dcan8prl1/image/upload/v1727095166/tyflasqpdnvol5mi6czm.jpg",
                            Name = "Huawei P30 Pro",
                            Price = 599m,
                            states = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
