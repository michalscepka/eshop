using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eshop.Infrastructure.Persistence.Models;

public class ProductModel : IEntityTypeConfiguration<ProductModel>
{
    [Key]
    public Guid Id { get; init; }
    
    [MaxLength(50)]
    public string Name { get; init; } = null!;
    
    public Uri ImgUri { get; init; } = null!;
    
    [Range(minimum: 0, maximum: double.MaxValue, ErrorMessage = "Price must be greater than zero")]
    [Precision(precision: 18, scale: 2)]
    public decimal Price { get; init; }
    
    [MaxLength(200)]
    public string? Description { get; set; }
    
    public DateTime CreatedAt { get; init; }
    
    public void Configure(EntityTypeBuilder<ProductModel> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");
        
        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(50);
        
        builder.Property(p => p.ImgUri)
            .IsRequired()
            .HasMaxLength(200)
            .HasConversion(v => v.ToString(), v => new Uri(v));
        
        builder.Property(p => p.Price)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(p => p.Description)
            .HasMaxLength(200);
        
        builder.Property(p => p.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");
    }
}
