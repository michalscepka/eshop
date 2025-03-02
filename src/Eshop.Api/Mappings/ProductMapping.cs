using Eshop.Api.Dtos;
using Eshop.Domain.Entities;

namespace Eshop.Api.Mappings;

internal static class ProductMapping
{
    public static ProductResponse ToResponse(this Product product) =>
        new(product.Id, product.Name, product.Price, product.ImgUri, product.Description);
}
