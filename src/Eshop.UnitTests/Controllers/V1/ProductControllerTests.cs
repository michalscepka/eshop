using Eshop.Api.Controllers.V1;
using Eshop.Api.Dtos;
using Eshop.Infrastructure.Persistence.Mocking;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.UnitTests.Controllers.V1;

public class ProductControllerTests
{
    private readonly ProductMockRepository _mockProductRepository;
    private readonly ProductController _controller;

    public ProductControllerTests()
    {
        _mockProductRepository = new ProductMockRepository();
        _controller = new ProductController(_mockProductRepository);
    }

    [Fact]
    public async Task GetAll_ReturnsOk_WithListOfProducts()
    {
        // Arrange
        var expectedProducts = await _mockProductRepository.GetAllAsync();

        // Act
        var result = await _controller.GetAll();

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        var returnValue = Assert.IsAssignableFrom<IEnumerable<ProductResponse>>(okResult.Value);
        Assert.Equal(expectedProducts.Count(), returnValue.Count());
    }

    [Fact]
    public async Task GetById_ReturnsOkResult_WithProduct()
    {
        // Arrange
        var product = (await _mockProductRepository.GetAllAsync()).First();

        // Act
        var result = await _controller.GetById(product.Id);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        var returnValue = Assert.IsType<ProductResponse>(okResult.Value);
        Assert.Equal(product.Id, returnValue.Id);
        Assert.Equal(product.Name, returnValue.Name);
        Assert.Equal(product.Description, returnValue.Description);
        Assert.Equal(product.ImgUri, returnValue.ImgUri);
        Assert.Equal(product.Price, returnValue.Price);
    }

    [Fact]
    public async Task GetById_ReturnsNotFoundResult_WhenProductNotFound()
    {
        // Arrange
        var productId = Guid.NewGuid();

        // Act
        var result = await _controller.GetById(productId);

        // Assert
        var notFoundResult = Assert.IsType<NotFoundObjectResult>(result.Result);
        Assert.Equal($"Product {productId} not found", notFoundResult.Value);
    }

    [Fact]
    public async Task UpdateDescription_ReturnsNoContent_WhenSuccessful()
    {
        // Arrange
        var product = (await _mockProductRepository.GetAllAsync()).First();
        var updateRequest = new UpdateProductDescriptionRequest("New Description");

        // Act
        var result = await _controller.UpdateDescription(product.Id, updateRequest);

        // Assert
        Assert.IsType<NoContentResult>(result);
        Assert.Equal(updateRequest.Description, product.Description);
    }

    [Fact]
    public async Task UpdateDescription_ReturnsNotFound_WhenProductNotFound()
    {
        // Arrange
        var productId = Guid.NewGuid();
        var updateRequest = new UpdateProductDescriptionRequest(Description: "New Description");

        // Act
        var result = await _controller.UpdateDescription(productId, updateRequest);

        // Assert
        Assert.IsType<NotFoundResult>(result);
    }
}
