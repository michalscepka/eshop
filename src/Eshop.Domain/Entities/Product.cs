using System.ComponentModel.DataAnnotations;

namespace Eshop.Domain.Entities;

public class Product
{
    public required Guid Id { get; set; }
    
    [MaxLength(50)]
    public required string Name { get; set; }
    
    public required Uri ImgUri { get; set; }
    
    public required decimal Price { get; set; }
    
    public string? Description { get; set; }
}
