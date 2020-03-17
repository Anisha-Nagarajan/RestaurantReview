using RestaurantEntity;
using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Data.Entity;
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
            //using (var restaurantDb = new RestaurantDbContext())
            //{
            //try
            //{
            //restaurantDb.Restaurants.Add(restaurant);
            //restaurantDb.SaveChanges();
            //}
            //catch(DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}
            //}

            using (var restaurantDb = new RestaurantDbContext())
            {
                if (!restaurantDb.Restaurants.Any(res => res.RestaurantId == restaurant.RestaurantId))
                {
                    using (DbContextTransaction tran = restaurantDb.Database.BeginTransaction())
                    {
                        try
                        {
                            restaurantDb.Restaurants.Add(restaurant);
                            restaurantDb.SaveChanges();
                            tran.Commit();
                        }
                        catch (Exception)
                        {
                            tran.Rollback();

                        }
                    }

                }
                else
                {
                    return;
                }
            }
        }
        public static Restaurant GetRestaurantById(int id)
        {
            Restaurant restaurant;
            using (var restaurantDb = new RestaurantDbContext())
            {
                restaurant = restaurantDb.Restaurants.FirstOrDefault(res => res.RestaurantId == id);
            }
            return restaurant;
        }
        public static void Update(Restaurant restaurant)
        {
            using (var restaurantDb = new RestaurantDbContext())
            {

                Restaurant updatedRestaurant = restaurantDb.Restaurants.FirstOrDefault(res => res.RestaurantId == restaurant.RestaurantId);
                updatedRestaurant.RestaurantId = restaurant.RestaurantId;
                updatedRestaurant.Name = restaurant.Name;
                updatedRestaurant.Description = restaurant.Description;
                updatedRestaurant.City = restaurant.City.ToString();
                updatedRestaurant.Alcohol = restaurant.Alcohol;
                updatedRestaurant.Services = restaurant.Services;
                updatedRestaurant.Cuisine = restaurant.Cuisine.ToString();
                updatedRestaurant.WorkingDays = restaurant.WorkingDays;
                updatedRestaurant.OpeningTime = restaurant.OpeningTime;
                updatedRestaurant.ClosingTime = restaurant.ClosingTime;
                updatedRestaurant.Email = restaurant.Email;
                updatedRestaurant.RestaurantWebsite = restaurant.RestaurantWebsite;
                restaurantDb.SaveChanges();
            }
        }
        public static void Delete(int resId)
        {
            using (var restaurantDb = new RestaurantDbContext())
            {
                Restaurant restaurant = GetRestaurantById(resId);
                if (restaurant != null)
                {
                    restaurantDb.Restaurants.Attach(restaurant);
                    restaurantDb.Restaurants.Remove(restaurant);
                    restaurantDb.SaveChanges();

                }
            }
        }
    }
}
