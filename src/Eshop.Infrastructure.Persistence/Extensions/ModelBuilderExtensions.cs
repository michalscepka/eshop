using Eshop.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Infrastructure.Persistence.Extensions;

public static class ModelBuilderExtensions
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductModel>().HasData(
            new ProductModel
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                Name = "Product 1",
                ImgUri = new Uri("https://example.com/product1.png"),
                Price = 10m,
                Description = "Product 1 description",
                CreatedAt = new DateTime(2024, 2, 25, 12, 0, 0, DateTimeKind.Utc)
            },
            new ProductModel
            {
                Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                Name = "Product 2",
                ImgUri = new Uri("https://example.com/product2.png"),
                Price = 15.50m,
                Description = "A high-quality product for everyday use.",
                CreatedAt = new DateTime(2024, 2, 26, 14, 30, 0, DateTimeKind.Utc)
            },
            new ProductModel
            {
                Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                Name = "Product 3",
                ImgUri = new Uri("https://example.com/product3.png"),
                Price = 7.99m,
                Description = "A budget-friendly product with great features.",
                CreatedAt = new DateTime(2024, 2, 27, 9, 15, 0, DateTimeKind.Utc)
            },
            new ProductModel
            {
                Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                Name = "Product 4",
                ImgUri = new Uri("https://example.com/product4.png"),
                Price = 25m,
                Description = "A premium product with top-tier performance.",
                CreatedAt = new DateTime(2024, 2, 28, 16, 45, 0, DateTimeKind.Utc)
            },
            new ProductModel
            {
                Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
                Name = "Product 5",
                ImgUri = new Uri("https://example.com/product5.png"),
                Price = 12.75m,
                Description = "A stylish and durable product for modern users.",
                CreatedAt = new DateTime(2024, 2, 29, 11, 0, 0, DateTimeKind.Utc)
            },
            new ProductModel
            {
                Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),
                Name = "Product 6",
                ImgUri = new Uri("https://example.com/product6.png"),
                Price = 19.99m,
                Description = "A compact and lightweight product, ideal for travel.",
                CreatedAt = new DateTime(2024, 3, 1, 10, 15, 0, DateTimeKind.Utc)
            },
            new ProductModel
            {
                Id = Guid.Parse("77777777-7777-7777-7777-777777777777"),
                Name = "Product 7",
                ImgUri = new Uri("https://example.com/product7.png"),
                Price = 8.49m,
                Description = "An eco-friendly product made from sustainable materials.",
                CreatedAt = new DateTime(2024, 3, 2, 13, 20, 0, DateTimeKind.Utc)
            },
            new ProductModel
            {
                Id = Guid.Parse("88888888-8888-8888-8888-888888888888"),
                Name = "Product 8",
                ImgUri = new Uri("https://example.com/product8.png"),
                Price = 30.00m,
                Description = "A luxury product for those who appreciate fine quality.",
                CreatedAt = new DateTime(2024, 3, 3, 17, 10, 0, DateTimeKind.Utc)
            },
            new ProductModel
            {
                Id = Guid.Parse("99999999-9999-9999-9999-999999999999"),
                Name = "Product 9",
                ImgUri = new Uri("https://example.com/product9.png"),
                Price = 5.99m,
                Description = "An affordable and practical product for daily needs.",
                CreatedAt = new DateTime(2024, 3, 4, 8, 30, 0, DateTimeKind.Utc)
            },
            new ProductModel
            {
                Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                Name = "Product 10",
                ImgUri = new Uri("https://example.com/product10.png"),
                Price = 22.50m,
                Description = "A well-designed product with ergonomic features.",
                CreatedAt = new DateTime(2024, 3, 5, 15, 45, 0, DateTimeKind.Utc)
            },
            new ProductModel
            {
                Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                Name = "Product 11",
                ImgUri = new Uri("https://example.com/product11.png"),
                Price = 14.00m,
                Description = "A durable and reliable product for long-term use.",
                CreatedAt = new DateTime(2024, 3, 6, 12, 10, 0, DateTimeKind.Utc)
            },
            new ProductModel
            {
                Id = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                Name = "Product 12",
                ImgUri = new Uri("https://example.com/product12.png"),
                Price = 9.99m,
                Description = "A colorful and fun product for all ages.",
                CreatedAt = new DateTime(2024, 3, 7, 14, 30, 0, DateTimeKind.Utc)
            },
            new ProductModel
            {
                Id = Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                Name = "Product 13",
                ImgUri = new Uri("https://example.com/product13.png"),
                Price = 28.00m,
                Description = "A cutting-edge product with the latest technology.",
                CreatedAt = new DateTime(2024, 3, 8, 16, 45, 0, DateTimeKind.Utc)
            },
            new ProductModel
            {
                Id = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                Name = "Product 14",
                ImgUri = new Uri("https://example.com/product14.png"),
                Price = 6.50m,
                Description = "A simple but effective product for everyday use.",
                CreatedAt = new DateTime(2024, 3, 9, 10, 0, 0, DateTimeKind.Utc)
            },
            new ProductModel
            {
                Id = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                Name = "Product 15",
                ImgUri = new Uri("https://example.com/product15.png"),
                Price = 18.75m,
                Description = "A sleek and modern product for a contemporary lifestyle.",
                CreatedAt = new DateTime(2024, 3, 10, 9, 45, 0, DateTimeKind.Utc)
            }
        );
    }
}
