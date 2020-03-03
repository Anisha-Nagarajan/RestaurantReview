using RestaurantEntity;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantDAL
{
    public class RestaurantRepository
    {
       //public static RestaurantDbContext restaurantDb = new RestaurantDbContext();
        public static IEnumerable<Restaurant> RestaurantDetails()
        {
            IEnumerable<Restaurant> restaurantDetails;
            using (var restaurantDb = new RestaurantDbContext())
            {
                restaurantDetails = restaurantDb.Restaurants.ToList();
            }
            return restaurantDetails;
        } 
        public static void AddRestaurants(Restaurant restaurant)
        {
            //  RestaurantDbContext restaurantDb = new RestaurantDbContext();
            using (var restaurantDb = new RestaurantDbContext())
            {
                restaurantDb.Restaurants.Add(restaurant);
                restaurantDb.SaveChanges();
            }
        }
        public static Restaurant GetRestaurantById(int id)
        {
            Restaurant restaurant;
            using (var restaurantDb = new RestaurantDbContext())
            {
                restaurant = restaurantDb.Restaurants.FirstOrDefault(res => res.Id == id);
            }
            return restaurant;
        }
        public static void Update(Restaurant restaurant)
        {
            using (var restaurantDb = new RestaurantDbContext())
            {
                Restaurant updatedRestaurant = restaurantDb.Restaurants.FirstOrDefault(res => res.Id == restaurant.Id);
                updatedRestaurant.Id = restaurant.Id;
                updatedRestaurant.Name = restaurant.Name;
                updatedRestaurant.Description = restaurant.Description;
                restaurantDb.SaveChanges();
            } 
        }
        public static void Delete(int resId)
        {
            
            Restaurant restaurant = GetRestaurantById(resId);
            if (restaurant != null)
            {
                using (var restaurantDb = new RestaurantDbContext())
                {
                    restaurantDb.Restaurants.Remove(restaurant);
                    restaurantDb.SaveChanges();
                }
            } 
        }
    }
}
