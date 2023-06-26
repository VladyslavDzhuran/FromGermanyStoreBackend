using FromGermanyStoreDataAccessLibrary.DataAccess;
using FromGermanyStoreDataAccessLibrary.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;



namespace FromGermanyStoreBackend.Services
{
    public class ProductManagmentService : IProductManagmentService
    {
        private readonly ApplicationContext _context;
        public ProductManagmentService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            IEnumerable<Product> task = await _context.Products.ToListAsync();
            return task;
        }
    }
}
