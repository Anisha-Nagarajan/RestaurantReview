using RestaurantDAL;
using RestaurantEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBL
{
   public class RestaurantBusinessLogic
    {
        RestaurantRepository restaurantRepository = new RestaurantRepository();
        public static void RestaurantData(Restaurant restaurant)
        {
            RestaurantRepository.AddRestaurants(restaurant);
        }
        public static IEnumerable<Restaurant> RestaurantDetails()
        {
            IEnumerable<Restaurant> restaurantDetails = RestaurantRepository.RestaurantDetails();
            return restaurantDetails;
        }
        public static Restaurant RestaurantById(int id)
        {
           Restaurant restaurant = RestaurantRepository.GetRestaurantById(id);
           return restaurant;
        }
        public static void UpdateRestaurant(Restaurant restaurant)
        {
            RestaurantRepository.Update(restaurant);
        }
    }
}
