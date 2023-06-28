using FromGermanyStoreBackend.Requests;
using FromGermanyStoreBackend.Services;
using FromGermanyStoreDataAccessLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace FromGermanyStoreBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductManagmentService _productManagmentService;
        public ProductController(IProductManagmentService productManagmentService)
        {
            _productManagmentService = productManagmentService;
        }

        [HttpPost]
        public async Task<IActionResult> AddNewProductAsync (ProductItemRequest productItemRequest)
        {
            await _productManagmentService.AddNewProductAsync(productItemRequest);
            return Ok(productItemRequest);
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var products = await _productManagmentService.GetProductsAsync();
            return products;
        }

        [HttpGet("{ProductId:int}")]
        public async Task<Product> GetProductAsync (int ProductId)
        {
            var product = await _productManagmentService.GetProductAsync(ProductId);
            return product;
        }

        [HttpPut("{ProductId:int}")]
        public async Task UpdateProductAsync(ProductItemRequest productItemRequest, int ProductId)
        {
            await _productManagmentService.UpdateProductAsync(productItemRequest, ProductId);
        }

        [HttpDelete("{ProductId:int}")]
        public async Task DeleteProductAsync(int ProductId)
        {
            await _productManagmentService.DeleteProductAsync(ProductId);
        }
    }
}
