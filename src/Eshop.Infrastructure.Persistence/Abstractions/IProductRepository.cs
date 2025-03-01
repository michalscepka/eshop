using Eshop.Domain.Entities;

namespace Eshop.Infrastructure.Persistence.Abstractions;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<IEnumerable<Product>> GetAllPaginatedAsync(int pageNumber, int pageSize);
    Task<Product?> GetByIdAsync(Guid id);
    Task<bool> UpdateDescriptionAsync(Guid id, string description);
}
