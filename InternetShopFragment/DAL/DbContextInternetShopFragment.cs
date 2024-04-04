using InternetShopFragment.Models;
using Microsoft.EntityFrameworkCore;

namespace InternetShopFragment.DAL
{
    public class DbContextInternetShopFragment : DbContext
    {
        public DbContextInternetShopFragment(DbContextOptions<DbContextInternetShopFragment> options) : base(options)
        { }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

    }
    
}
