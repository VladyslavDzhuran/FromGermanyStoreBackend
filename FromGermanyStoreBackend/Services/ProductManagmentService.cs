using FromGermanyStoreDataAccessLibrary.DataAccess;
using FromGermanyStoreDataAccessLibrary.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using FromGermanyStoreBackend.Requests;

namespace FromGermanyStoreBackend.Services
{
    public class ProductManagmentService : IProductManagmentService
    {
        private readonly ApplicationContext _context;
        public ProductManagmentService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task AddNewProductAsync(ProductItemRequest productItem)
        {
            var product = new Product()
            {
                Title = productItem.Title,
                Price = productItem.Price,
                Description = productItem.Description,
                Category = productItem.Category
            };

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            IEnumerable<Product> task = await _context.Products.ToListAsync();
            return task;
        }

        public async Task<Product> GetProductAsync(int ProductId)
        {
            var product = await _context.Products.FindAsync(ProductId);

            if (product == null) throw new NullReferenceException();

            return product;
        }

        public async Task UpdateProductAsync(ProductItemRequest productItem, int ProductId)
        {
            var oldProduct = await GetProductAsync(ProductId);

            oldProduct.Title= productItem.Title;
            oldProduct.Price = productItem.Price;
            oldProduct.Description = productItem.Description;
            oldProduct.Category = productItem.Category;

            _context.Entry(oldProduct).State= EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int ProductId)
        {
            var product = await GetProductAsync(ProductId);

            if(product == null) throw new NullReferenceException();

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}
