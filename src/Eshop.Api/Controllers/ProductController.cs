using Eshop.Api.Dtos;
using Eshop.Infrastructure.Persistence.Repositories.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Api.Controllers;

[ApiController]
[Route("api/product")]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await _productRepository.GetAllAsync();
        return Ok(products);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var product = await _productRepository.GetByIdAsync(id);
        
        if (product is null)
            return NotFound($"Product {id} not found");
        
        return Ok(product);
    }

    [HttpPatch("{id:guid}/description")]
    public async Task<IActionResult> UpdateDescription([FromRoute] Guid id, [FromBody] UpdateProductDescriptionRequest updateRequest)
    {
        if (string.IsNullOrWhiteSpace(updateRequest.Description))
            return BadRequest("Description cannot be empty.");

        var isUpdated = await _productRepository.UpdateDescriptionAsync(id, updateRequest.Description);

        return isUpdated
            ? NoContent()
            : NotFound();
    }
}
