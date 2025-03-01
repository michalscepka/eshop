using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Eshop.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "ImgUri", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2024, 2, 25, 12, 0, 0, 0, DateTimeKind.Utc), "Product 1 description", "https://example.com/product1.png", "Product 1", 10m },
                    { new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2024, 2, 26, 14, 30, 0, 0, DateTimeKind.Utc), "A high-quality product for everyday use.", "https://example.com/product2.png", "Product 2", 15.50m },
                    { new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2024, 2, 27, 9, 15, 0, 0, DateTimeKind.Utc), "A budget-friendly product with great features.", "https://example.com/product3.png", "Product 3", 7.99m },
                    { new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2024, 2, 28, 16, 45, 0, 0, DateTimeKind.Utc), "A premium product with top-tier performance.", "https://example.com/product4.png", "Product 4", 25m },
                    { new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 2, 29, 11, 0, 0, 0, DateTimeKind.Utc), "A stylish and durable product for modern users.", "https://example.com/product5.png", "Product 5", 12.75m },
                    { new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2024, 3, 1, 10, 15, 0, 0, DateTimeKind.Utc), "A compact and lightweight product, ideal for travel.", "https://example.com/product6.png", "Product 6", 19.99m },
                    { new Guid("77777777-7777-7777-7777-777777777777"), new DateTime(2024, 3, 2, 13, 20, 0, 0, DateTimeKind.Utc), "An eco-friendly product made from sustainable materials.", "https://example.com/product7.png", "Product 7", 8.49m },
                    { new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 3, 3, 17, 10, 0, 0, DateTimeKind.Utc), "A luxury product for those who appreciate fine quality.", "https://example.com/product8.png", "Product 8", 30.00m },
                    { new Guid("99999999-9999-9999-9999-999999999999"), new DateTime(2024, 3, 4, 8, 30, 0, 0, DateTimeKind.Utc), "An affordable and practical product for daily needs.", "https://example.com/product9.png", "Product 9", 5.99m },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2024, 3, 5, 15, 45, 0, 0, DateTimeKind.Utc), "A well-designed product with ergonomic features.", "https://example.com/product10.png", "Product 10", 22.50m },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2024, 3, 6, 12, 10, 0, 0, DateTimeKind.Utc), "A durable and reliable product for long-term use.", "https://example.com/product11.png", "Product 11", 14.00m },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), new DateTime(2024, 3, 7, 14, 30, 0, 0, DateTimeKind.Utc), "A colorful and fun product for all ages.", "https://example.com/product12.png", "Product 12", 9.99m },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), new DateTime(2024, 3, 8, 16, 45, 0, 0, DateTimeKind.Utc), "A cutting-edge product with the latest technology.", "https://example.com/product13.png", "Product 13", 28.00m },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2024, 3, 9, 10, 0, 0, 0, DateTimeKind.Utc), "A simple but effective product for everyday use.", "https://example.com/product14.png", "Product 14", 6.50m },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2024, 3, 10, 9, 45, 0, 0, DateTimeKind.Utc), "A sleek and modern product for a contemporary lifestyle.", "https://example.com/product15.png", "Product 15", 18.75m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"));
        }
    }
}
