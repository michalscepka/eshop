using Asp.Versioning;
using Eshop.Api.Dtos;
using Eshop.Api.Mappings;
using Eshop.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

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
    
    [HttpGet]
    public async Task<ActionResult<ProductResponse>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
    {
        if (pageNumber < 1 || pageSize < 1)
            return BadRequest("Page number and page size must be greater than 0.");
            
        var products = await _productRepository.GetAllPaginatedAsync(pageNumber, pageSize);

        var response = products.Select(p => p.ToResponse());
        
        return Ok(response);
    }
}
