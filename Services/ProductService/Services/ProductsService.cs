
using Microsoft.EntityFrameworkCore;
using ProductService.Data;
using ProductService.Models;

namespace ProductService.Services
{
    public class ProductsService
    {
        private readonly ProductDbContext _context;

        public ProductsService(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAsync() =>
            await _context.Products.ToListAsync();

        public async Task<Product?> GetAsync(int id) =>
            await _context.Products.FirstOrDefaultAsync(x => x.Id == id);

        public async Task CreateAsync(Product newProduct)
        {
            _context.Products.Add(newProduct);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Product updatedProduct)
        {
            var existingProduct = await _context.Products.FindAsync(id);
            if (existingProduct != null)
            {
                existingProduct.ProductName = updatedProduct.ProductName;
                existingProduct.Description = updatedProduct.Description;
                existingProduct.Price = updatedProduct.Price;
                existingProduct.Quantity = updatedProduct.Quantity;
                await _context.SaveChangesAsync();
            }
        }

        public async Task RemoveAsync(int id)
        {
            var productToRemove = await _context.Products.FindAsync(id);
            if (productToRemove != null)
            {
                _context.Products.Remove(productToRemove);
                await _context.SaveChangesAsync();
            }
        }
    }
}