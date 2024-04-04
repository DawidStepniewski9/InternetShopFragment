using InternetShopFragment.DAL;
using InternetShopFragment.Models;
using Microsoft.EntityFrameworkCore;

namespace InternetShopFragment.Repositories
{
    public class UserRepository
    {
        private readonly DbContextInternetShopFragment _db;
        public UserRepository(DbContextInternetShopFragment db)
        {
            _db = db;
        }
        public async Task CreateUser(User user)
        {
            await _db.Users.AddAsync(user);
            await _db.SaveChangesAsync();
        }
        public async Task<User> GetById(long id)
        {
            return await _db.Users.FindAsync(id);
        }
        public async Task<List<User>> GetAll()
        {
            return await _db.Users.ToListAsync();
        }
        public async Task UpdateCart(User user)
        {
            _db.Users.Update(user);
            await _db.SaveChangesAsync();
        }
        public async Task DeleteCart(User user)
        {
            _db.Users.Remove(user);
            await _db.SaveChangesAsync();
        }
    }
}
