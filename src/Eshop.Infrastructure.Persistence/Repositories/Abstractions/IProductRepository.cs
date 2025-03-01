using Eshop.Domain.Entities;

namespace Eshop.Infrastructure.Persistence.Repositories.Abstractions;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(Guid id);
    Task<bool> UpdateDescriptionAsync(Guid id, string description);
}
