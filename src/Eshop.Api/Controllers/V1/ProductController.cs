using Asp.Versioning;
using Eshop.Api.Dtos;
using Eshop.Api.Mappings;
using Eshop.Infrastructure.Persistence.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Api.Controllers.V1;

[ApiController]
[Route("api/v{version:apiVersion}/product")]
[ApiVersion(1.0)]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductResponse>>> GetAll()
    {
        var products = await _productRepository.GetAllAsync();

        var response = products.Select(p => p.ToResponse());
        
        return Ok(response);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<ProductResponse>> GetById([FromRoute] Guid id)
    {
        var product = await _productRepository.GetByIdAsync(id);
        
        if (product is null)
            return NotFound($"Product {id} not found");
        
        var response = product.ToResponse();
        
        return Ok(response);
    }

    [HttpPatch("{id:guid}/description")]
    public async Task<IActionResult> UpdateDescription([FromRoute] Guid id, [FromBody] UpdateProductDescriptionRequest updateRequest)
    {
        var isUpdated = await _productRepository.UpdateDescriptionAsync(id, updateRequest.Description);

        return isUpdated
            ? NoContent()
            : NotFound();
    }
}
