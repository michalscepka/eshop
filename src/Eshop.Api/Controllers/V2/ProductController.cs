using Asp.Versioning;
using Eshop.Api.Dtos;
using Eshop.Api.Mappings;
using Eshop.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Eshop.Api.Controllers.V2;

[ApiController]
[Route("api/v{version:apiVersion}/product")]
[ApiVersion(2.0)]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    /// <summary>
    /// Retrieves a paginated list of products.
    /// </summary>
    /// <param name="pageNumber">The page number to retrieve (default is 1).</param>
    /// <param name="pageSize">The number of products per page (default is 10).</param>
    /// <returns>A paginated list of products.</returns>
    /// <response code="200">Returns the paginated list of products.</response>
    /// <response code="400">If pageNumber or pageSize is less than 1.</response>
    [HttpGet]
    [SwaggerOperation(Summary = "Retrieves paginated products", Description = "Gets a paginated list of products based on the provided page number and page size.")]
    [SwaggerResponse(200, "Successfully retrieved paginated products.", typeof(IEnumerable<ProductResponse>))]
    [SwaggerResponse(400, "Invalid pagination parameters.")]

    public async Task<ActionResult<ProductResponse>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
    {
        if (pageNumber < 1 || pageSize < 1)
            return BadRequest("Page number and page size must be greater than 0.");
            
        var products = await _productRepository.GetAllPaginatedAsync(pageNumber, pageSize);

        var response = products.Select(p => p.ToResponse());
        
        return Ok(response);
    }
}
