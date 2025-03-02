using Eshop.Domain.Entities;
using Eshop.Domain.Repositories;
using Eshop.Infrastructure.Persistence.Extensions;
using Eshop.Infrastructure.Persistence.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Infrastructure.Persistence.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly EshopDbContext _dbContext;

    public ProductRepository(EshopDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        var productsModel = await _dbContext.Products.ToListAsync();
        
        return productsModel.Select(p => p.ToDomain());
    }

    public async Task<IEnumerable<Product>> GetAllPaginatedAsync(int pageNumber, int pageSize)
    {
        var productsModel = await _dbContext.Products
            .Paginate(pageNumber, pageSize)
            .ToListAsync();
        
        return productsModel.Select(p => p.ToDomain());
    }

    public async Task<Product?> GetByIdAsync(Guid id)
    {
        var productModel = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == id);

        return productModel?.ToDomain();
    }

    public async Task<bool> UpdateDescriptionAsync(Guid id, string description)
    {
        var product = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
        
        if (product is null)
            return false;
        
        product.Description = description;
        
        _dbContext.Products.Update(product);
        await _dbContext.SaveChangesAsync();
        
        return true;
    }
}
