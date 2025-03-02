using Eshop.Domain.Entities;
using Eshop.Domain.Repositories;

namespace Eshop.Infrastructure.Persistence.Mocking;

public class ProductMockRepository : IProductRepository
{
    private readonly List<Product> _products;
    
    public ProductMockRepository()
    {
        _products = ProductMockData.GetMockProducts();
    }
    
    public Task<IEnumerable<Product>> GetAllAsync()
    {
        return Task.FromResult(_products.AsEnumerable());
    }

    public Task<IEnumerable<Product>> GetAllPaginatedAsync(int pageNumber, int pageSize)
    {
        var products = _products
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize);
        
        return Task.FromResult(products.AsEnumerable());
    }

    public Task<Product?> GetByIdAsync(Guid id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);

        return Task.FromResult(product);
    }

    public Task<bool> UpdateDescriptionAsync(Guid id, string description)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        
        if (product is null)
            return Task.FromResult(false);
        
        product.Description = description;
        
        return Task.FromResult(true);
    }
}
