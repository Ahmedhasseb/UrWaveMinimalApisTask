using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UrWave.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CreateDate", "Description", "ImageUrl", "Name", "Price", "states" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1136), "Apple iPhone 13 with A15 Bionic chip", "http://res.cloudinary.com/dcan8prl1/image/upload/v1725289186/ilqyuyvu88l5mvetolks.jpg", "iPhone 13", 799m, 0 },
                    { 2, new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1187), "Apple iPhone 13 Pro with triple camera system", "http://res.cloudinary.com/dcan8prl1/image/upload/v1725289234/big9pzjorkqgd2ktjk0r.jpg", "iPhone 13 Pro", 999m, 0 },
                    { 3, new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1191), "Apple iPhone 12 with A14 Bionic chip", "http://res.cloudinary.com/dcan8prl1/image/upload/v1725289271/bh23hfxzvkbgqdvctjm6.jpg", "iPhone 12", 699m, 0 },
                    { 4, new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1195), "Apple iPhone 12 Pro with LiDAR scanner", "http://res.cloudinary.com/dcan8prl1/image/upload/v1725289297/lb9pd49w7cjgy4lihxrs.jpg", "iPhone 12 Pro", 899m, 0 },
                    { 5, new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1199), "Apple iPhone SE with A13 Bionic chip", "http://res.cloudinary.com/dcan8prl1/image/upload/v1726419551/htqp0xfkwe3ami3nprpm.jpg", "iPhone SE", 399m, 0 },
                    { 6, new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1203), "Samsung Galaxy S21 with Exynos 2100", "http://res.cloudinary.com/dcan8prl1/image/upload/v1726419375/ujawtrymxj1n07gpezci.jpg", "Samsung Galaxy S21", 799m, 0 },
                    { 7, new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1207), "Samsung Galaxy S21 Ultra with 108MP camera", "http://res.cloudinary.com/dcan8prl1/image/upload/v1726419397/cx2le61pqegbcwl0o9hg.jpg", "Samsung Galaxy S21 Ultra", 1199m, 0 },
                    { 8, new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1210), "Samsung Galaxy Note 20 with S Pen", "http://res.cloudinary.com/dcan8prl1/image/upload/v1726419420/eptsgp47br7xnosezhuq.jpg", "Samsung Galaxy Note 20", 999m, 0 },
                    { 9, new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1213), "Samsung Galaxy A52 with Snapdragon 720G", "http://res.cloudinary.com/dcan8prl1/image/upload/v1726419447/r4gxty3nd2jycprjk44z.jpg", "Samsung Galaxy A52", 399m, 0 },
                    { 10, new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1216), "Samsung Galaxy Z Fold 3 with foldable display", "http://res.cloudinary.com/dcan8prl1/image/upload/v1726419472/ypualvh9yyfurcpgyutn.jpg", "Samsung Galaxy Z Fold 3", 1799m, 0 },
                    { 11, new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1219), "Huawei P40 with Kirin 990 5G", "http://res.cloudinary.com/dcan8prl1/image/upload/v1727094367/qecgksj5wgqip1uc7rdq.jpg", "Huawei P40", 699m, 0 },
                    { 12, new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1222), "Huawei Mate 40 Pro with Kirin 9000 5G", "http://res.cloudinary.com/dcan8prl1/image/upload/v1727094403/tps9v5i5ldo9vhsvlyph.jpg", "Huawei Mate 40 Pro", 1099m, 0 },
                    { 13, new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1225), "Huawei Nova 7i with Kirin 810", "http://res.cloudinary.com/dcan8prl1/image/upload/v1727094423/ddes01kvtshludrselb9.jpg", "Huawei Nova 7i", 299m, 0 },
                    { 14, new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1228), "Huawei Y9a with MediaTek Helio G80", "http://res.cloudinary.com/dcan8prl1/image/upload/v1727094451/z0tp2io09zlv0j0ph41g.jpg", "Huawei Y9a", 249m, 0 },
                    { 15, new DateTime(2024, 12, 31, 15, 33, 46, 457, DateTimeKind.Local).AddTicks(1230), "Huawei P30 Pro with Leica quad camera", "http://res.cloudinary.com/dcan8prl1/image/upload/v1727095166/tyflasqpdnvol5mi6czm.jpg", "Huawei P30 Pro", 599m, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
