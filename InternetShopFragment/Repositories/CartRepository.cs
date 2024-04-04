using InternetShopFragment.DAL;
using InternetShopFragment.Models;
using Microsoft.EntityFrameworkCore;

namespace InternetShopFragment.Repositories
{
    public class CartRepository
    {
        private readonly DbContextInternetShopFragment _db;
        public CartRepository(DbContextInternetShopFragment db)
        {
            _db = db;
        }
        public async Task CreateCart(Cart cart)
        {
            await _db.Carts.AddAsync(cart);
            await _db.SaveChangesAsync();
        }
        public async Task<Cart> GetById(long id)
        {
            return await _db.Carts.FindAsync(id);
        }
        public async Task<List<Cart>> GetAll()
        { 
            return await _db.Carts.ToListAsync();
        }
        public async Task UpdateCart(Cart cart)
        {
            _db.Carts.Update(cart);
            await _db.SaveChangesAsync();
        }
        public async Task DeleteCart(Cart cart)
        {
            _db.Carts.Remove(cart);
            await _db.SaveChangesAsync();
        }
    }
}
