namespace Eshop.Api.Dtos;

public record ProductResponse(Guid Id, string Name, decimal Price, Uri ImgUri, string? Description);
