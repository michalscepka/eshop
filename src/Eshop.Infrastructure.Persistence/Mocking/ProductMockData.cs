using Eshop.Domain.Entities;

namespace Eshop.Infrastructure.Persistence.Mocking;

public static class ProductMockData
{
    public static List<Product> GetMockProducts()
    {
        return
        [
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 1",
                Description = "Description 1",
                Price = 10m,
                ImgUri = new Uri("https://example.com/product1.png"),
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 2",
                Description = "Description 2",
                Price = 20m,
                ImgUri = new Uri("https://example.com/product1.png"),
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 3",
                Description = "Description 3",
                Price = 30m,
                ImgUri = new Uri("https://example.com/product1.png"),
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 4",
                Description = "Description 4",
                Price = 40m,
                ImgUri = new Uri("https://example.com/product1.png"),
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 5",
                Description = "Description 5",
                Price = 50m,
                ImgUri = new Uri("https://example.com/product1.png"),
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 6",
                Description = "Description 6",
                Price =  60m,
                ImgUri = new Uri("https://example.com/product1.png"),
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 7",
                Description = "Description 7",
                Price = 70m,
                ImgUri = new Uri("https://example.com/product1.png"),
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 8",
                Description = "Description 8",
                Price = 80m,
                ImgUri = new Uri("https://example.com/product1.png"),
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 9",
                Description = "Description 9",
                Price = 90m,
                ImgUri = new Uri("https://example.com/product1.png"),
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 10",
                Description = "Description 10",
                Price = 100m,
                ImgUri = new Uri("https://example.com/product1.png"),
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 11",
                Description = "Description 11",
                Price = 110m,
                ImgUri = new Uri("https://example.com/product1.png"),
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 12",
                Description = "Description 12",
                Price = 120m,
                ImgUri = new Uri("https://example.com/product1.png"),
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 13",
                Description = "Description 13",
                Price = 130m,
                ImgUri = new Uri("https://example.com/product1.png"),
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 14",
                Description = "Description 14",
                Price = 140m,
                ImgUri = new Uri("https://example.com/product1.png"),
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 15",
                Description = "Description 15",
                Price = 150m,
                ImgUri = new Uri("https://example.com/product1.png"),
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 16",
                Description = "Description 16",
                Price = 160m,
                ImgUri = new Uri("https://example.com/product1.png"),
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 17",
                Description = "Description 17",
                Price = 170m,
                ImgUri = new Uri("https://example.com/product1.png"),
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 18",
                Description = "Description 18",
                Price = 180m,
                ImgUri = new Uri("https://example.com/product1.png"),
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 19",
                Description = "Description 19",
                Price = 190m,
                ImgUri = new Uri("https://example.com/product1.png"),
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Product 20",
                Description = "Description 20",
                Price = 200m,
                ImgUri = new Uri("https://example.com/product1.png"),
            }
        ];
    }
}
