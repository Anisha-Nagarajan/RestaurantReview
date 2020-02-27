using RestaurantEntity;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantDAL
{
    public class RestaurantRepository
    {
       public static RestaurantDbContext restaurantDb = new RestaurantDbContext();
        public static IEnumerable<Restaurant> CreateRestaurantDb()
        {
           RestaurantDbContext restaurantDb = new RestaurantDbContext();
            return restaurantDb.Restaurants.ToList();
        }
        public static void AddRestaurants(Restaurant restaurant)
        {
          //  RestaurantDbContext restaurantDb = new RestaurantDbContext();
            restaurantDb.Restaurants.Add(restaurant);
            restaurantDb.SaveChanges();
        }
        public static Restaurant GetRestaurantById(int id)
        {
            return restaurantDb.Restaurants.FirstOrDefault(res => res.Id == id);
        }
        public static void Update(Restaurant restaurant)
        {
            Restaurant updatedRestaurant = restaurantDb.Restaurants.FirstOrDefault(res => res.Id == restaurant.Id);
            updatedRestaurant.Id = restaurant.Id;
            updatedRestaurant.Name = restaurant.Name;
            updatedRestaurant.Description = restaurant.Description;
        }
        public static void Delete(int resId)
        {
            Restaurant restaurant = GetRestaurantById(resId);
            if (restaurant != null)
            {
                restaurantDb.Restaurants.Remove(restaurant);
            }
        }
    }
}
