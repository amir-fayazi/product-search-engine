using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Serach.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class change4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categoris",
                columns: new[] { "Id", "Name_Value" },
                values: new object[] { 4, "Headphones" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "Stock", "Title" },
                values: new object[] { 1200m, 7, "Asus VivoBook 15" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "Color", "Price", "Stock", "Title" },
                values: new object[] { "Asus", "Silver", 2000m, 4, "Asus Zenbook Pro 14" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "Color", "Price", "Stock", "Title" },
                values: new object[,]
                {
                    { 3, "Lenovo", 1, "Black", 2200m, 3, "Lenovo ThinkPad X1" },
                    { 4, "Apple", 1, "Silver", 3500m, 2, "Apple MacBook Pro 14" },
                    { 5, "Dell", 1, "Gray", 2200m, 0, "Dell XPS 13" },
                    { 6, "Samsung", 2, "Black", 500m, 12, "Samsung Galaxy A55" },
                    { 7, "Samsung", 2, "Silver", 950m, 5, "Samsung Galaxy S24" },
                    { 8, "Apple", 2, "Black", 1500m, 4, "Apple iPhone 16 Pro" },
                    { 9, "Apple", 2, "Blue", 1000m, 0, "Apple iPhone 15" },
                    { 10, "Xiaomi", 2, "Black", 600m, 9, "Xiaomi Redmi Note 14 Pro" },
                    { 11, "Logitech", 3, "Black", 25m, 30, "Logitech M185" },
                    { 12, "Logitech", 3, "Gray", 120m, 8, "Logitech MX Master 3S" },
                    { 13, "Razer", 3, "Black", 150m, 4, "Razer Viper V3 Pro" },
                    { 14, "A4Tech", 3, "White", 20m, 0, "A4Tech OP-620" },
                    { 15, "Logitech", 3, "White", 120m, 6, "Logitech G Pro X" },
                    { 16, "Sony", 4, "Black", 350m, 4, "Sony WH-1000XM5" },
                    { 17, "Sony", 4, "Blue", 120m, 10, "Sony WH-CH720N" },
                    { 18, "Apple", 4, "White", 280m, 5, "Apple AirPods Pro 2" },
                    { 19, "Samsung", 4, "Silver", 250m, 2, "Samsung Galaxy Buds3 Pro" },
                    { 20, "JBL", 4, "Black", 110m, 0, "JBL Tune 770NC" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categoris",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "Stock", "Title" },
                values: new object[] { 1500m, 3, "Laptop Asus k55d" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "Color", "Price", "Stock", "Title" },
                values: new object[] { "Lenovo", "Black", 1100m, 5, "Lenovo hln" });
        }
    }
}
