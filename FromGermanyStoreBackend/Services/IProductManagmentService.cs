using FromGermanyStoreBackend.Requests;
using FromGermanyStoreDataAccessLibrary.Models;

namespace FromGermanyStoreBackend.Services
{
    public interface IProductManagmentService
    {
        Task AddNewProductAsync(ProductItemRequest productItem);
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductAsync(int ProductId);
        Task UpdateProductAsync(ProductItemRequest productItem, int ProductId);
        Task DeleteProductAsync(int ProductId);
    }
}
