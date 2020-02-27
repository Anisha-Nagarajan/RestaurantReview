
using System.Data.Entity;
using RestaurantEntity;

namespace RestaurantDAL
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext() : base("DefaultConnection")
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
