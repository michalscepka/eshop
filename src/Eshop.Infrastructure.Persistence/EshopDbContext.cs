using Eshop.Infrastructure.Persistence.Extensions;
using Eshop.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Infrastructure.Persistence;

public class EshopDbContext : DbContext
{
    public EshopDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<ProductModel> Products { get; init; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EshopDbContext).Assembly);
        modelBuilder.SeedData();
    }
}
