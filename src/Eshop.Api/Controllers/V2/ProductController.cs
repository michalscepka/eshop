using Asp.Versioning;
using Eshop.Infrastructure.Persistence.Abstractions;
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
    public async Task<IActionResult> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
    {
        var products = await _productRepository.GetAllPaginatedAsync(pageNumber, pageSize);
        return Ok(products);
    }
}
