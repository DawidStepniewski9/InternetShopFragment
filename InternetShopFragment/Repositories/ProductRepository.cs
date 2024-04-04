using InternetShopFragment.DAL;
using InternetShopFragment.Models;
using Microsoft.EntityFrameworkCore;

namespace InternetShopFragment.Repositories
{
    public class ProductRepository
    {
        private readonly DbContextInternetShopFragment _db;
        public ProductRepository(DbContextInternetShopFragment db) 
        {
            _db = db;
        }
        public async Task CreateProduct(Product product)
        {
            await _db.Products.AddAsync(product);
            await _db.SaveChangesAsync();
        }
        public async Task<Product> GetById(long id)
        {
            return await _db.Products.FindAsync(id);
        }
        public async Task<List<Product>> GetAll()
        {
            return await _db.Products.ToListAsync();
        }
        public async Task UpdateProduct(Product product)
        {
            _db.Products.Update(product);
            await _db.SaveChangesAsync();
        }
        public async Task DeleteProduct(Product product)
        {
            _db.Products.Remove(product);
            await _db.SaveChangesAsync();
        }
    }
}
