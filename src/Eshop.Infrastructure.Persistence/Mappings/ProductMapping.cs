using Eshop.Domain.Entities;
using Eshop.Infrastructure.Persistence.Models;

namespace Eshop.Infrastructure.Persistence.Mappings;

internal static class ProductMapping
{
    public static Product ToDomain(this ProductModel productModel) => new()
    {
        Id = productModel.Id,
        Name = productModel.Name,
        Price = productModel.Price,
        ImgUri = productModel.ImgUri,
        Description = productModel.Description
    };
}
