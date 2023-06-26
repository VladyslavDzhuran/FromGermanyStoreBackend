using FromGermanyStoreDataAccessLibrary.Models;

namespace FromGermanyStoreBackend.Services
{
    public interface IProductManagmentService
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
