using Eshop.Api.Controllers.V2;
using Eshop.Api.Dtos;
using Eshop.Domain.Entities;
using Eshop.Infrastructure.Persistence.Abstractions;
using Eshop.Infrastructure.Persistence.Mocking;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Eshop.UnitTests.Controllers.V2;

public class ProductControllerTests
{
    private readonly ProductMockRepository _stubProductRepository;
    private readonly ProductController _stubController;
    private readonly Mock<IProductRepository> _mockProductRepository;
    private readonly ProductController _mockController;

    public ProductControllerTests()
    {
        _stubProductRepository = new ProductMockRepository();
        _stubController = new ProductController(_stubProductRepository);
        _mockProductRepository = new Mock<IProductRepository>();
        _mockController = new ProductController(_mockProductRepository.Object);
    }

    [Fact]
    public async Task GetAll_ReturnsOk_WithPaginatedProducts()
    {
        // Arrange
        const int pageNumber = 1;
        const int pageSize = 10;
        var expectedProducts = await _stubProductRepository.GetAllPaginatedAsync(pageNumber, pageSize);

        // Act
        var result = await _stubController.GetAll(pageNumber, pageSize);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        var returnValue = Assert.IsAssignableFrom<IEnumerable<ProductResponse>>(okResult.Value);
        Assert.Equal(expectedProducts.Count(), returnValue.Count());
    }

    [Fact]
    public async Task GetAll_ReturnsOkResult_WithEmptyList_WhenNoProducts()
    {
        // Arrange
        const int pageNumber = 1;
        const int pageSize = 10;
        _mockProductRepository
            .Setup(repo => repo.GetAllPaginatedAsync(pageNumber, pageSize))
            .ReturnsAsync(new List<Product>());

        // Act
        var result = await _mockController.GetAll(pageNumber, pageSize);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        var returnValue = Assert.IsAssignableFrom<IEnumerable<ProductResponse>>(okResult.Value);
        Assert.Empty(returnValue);
    }
    
    [Fact]
    public async Task GetAllProducts_ReturnsBadRequest_WhenPageNumberIsInvalid()
    {
        // Arrange
        const int pageNumber = -1;
        const int pageSize = 5;

        // Act
        var result = await _stubController.GetAll(pageNumber, pageSize);

        // Assert
        var badRequestResult = Assert.IsType<BadRequestObjectResult>(result.Result);
        Assert.Equal("Page number and page size must be greater than 0.", badRequestResult.Value);
    }
}
