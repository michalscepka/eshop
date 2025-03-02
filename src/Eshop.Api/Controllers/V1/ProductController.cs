using Asp.Versioning;
using Eshop.Api.Dtos;
using Eshop.Api.Mappings;
using Eshop.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

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
    
    /// <summary>
    /// Retrieves all products.
    /// </summary>
    /// <returns>A list of products.</returns>
    /// <response code="200">Returns the list of products.</response>
    [HttpGet]
    [SwaggerOperation(Summary = "Retrieves all products", Description = "Gets a list of all products.")]
    [SwaggerResponse(200, "Successfully retrieved products.", typeof(IEnumerable<ProductResponse>))]
    public async Task<ActionResult<IEnumerable<ProductResponse>>> GetAll()
    {
        var products = await _productRepository.GetAllAsync();

        var response = products.Select(p => p.ToResponse());
        
        return Ok(response);
    }

    /// <summary>
    /// Retrieves a product by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the product.</param>
    /// <returns>The product details.</returns>
    /// <response code="200">Returns the product details.</response>
    /// <response code="404">If the product is not found.</response>
    [HttpGet("{id:guid}")]
    [SwaggerOperation(Summary = "Retrieves a product by ID", Description = "Gets the details of a specific product using its ID.")]
    [SwaggerResponse(200, "Successfully retrieved product.", typeof(ProductResponse))]
    [SwaggerResponse(404, "Product not found.")]
    public async Task<ActionResult<ProductResponse>> GetById([FromRoute] Guid id)
    {
        var product = await _productRepository.GetByIdAsync(id);
        
        if (product is null)
            return NotFound($"Product {id} not found");
        
        var response = product.ToResponse();
        
        return Ok(response);
    }

    /// <summary>
    /// Updates the description of an existing product.
    /// </summary>
    /// <param name="id">The unique identifier of the product.</param>
    /// <param name="updateRequest">The new description to be updated.</param>
    /// <response code="204">If the update was successful.</response>
    /// <response code="404">If the product is not found.</response>
    [HttpPatch("{id:guid}/description")]
    [SwaggerOperation(Summary = "Updates product description", Description = "Updates the description of an existing product by its ID.")]
    [SwaggerResponse(204, "Description updated successfully.")]
    [SwaggerResponse(404, "Product not found.")]
    public async Task<IActionResult> UpdateDescription([FromRoute] Guid id, [FromBody] UpdateProductDescriptionRequest updateRequest)
    {
        var isUpdated = await _productRepository.UpdateDescriptionAsync(id, updateRequest.Description);

        return isUpdated
            ? NoContent()
            : NotFound();
    }
}
