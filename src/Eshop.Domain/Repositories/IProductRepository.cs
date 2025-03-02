using Eshop.Domain.Entities;

namespace Eshop.Domain.Repositories;

public interface IProductRepository
{
    /// <summary>
    /// Retrieves all products asynchronously.
    /// </summary>
    /// <returns>A task that represents an asynchronous operation, returning a collection of products.</returns>
    Task<IEnumerable<Product>> GetAllAsync();
    
    /// <summary>
    /// Retrieves a paginated list of products asynchronously.
    /// </summary>
    /// <param name="pageNumber">The page number to retrieve.</param>
    /// <param name="pageSize">The number of products per page.</param>
    /// <returns>A task that represents an asynchronous operation, returning a paginated collection of products.</returns>
    Task<IEnumerable<Product>> GetAllPaginatedAsync(int pageNumber, int pageSize);
    
    /// <summary>
    /// Retrieves a product by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the product.</param>
    /// <returns>A task that represents an asynchronous operation, returning the product if found; otherwise, null.</returns>
    Task<Product?> GetByIdAsync(Guid id);
    
    /// <summary>
    /// Updates the description of a product asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the product.</param>
    /// <param name="description">The new description for the product.</param>
    /// <returns>A task that represents an asynchronous operation, returning true if the update was successful; otherwise, false.</returns>
    Task<bool> UpdateDescriptionAsync(Guid id, string description);
}
