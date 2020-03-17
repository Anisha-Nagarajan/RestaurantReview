using System.Web.Mvc;
using RestaurantEntity;
using System.Collections.Generic;
using RestaurantEF.ViewModels;
using RestaurantBL;
using System;

namespace RestaurantEF.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Index()
        {
            IEnumerable<Restaurant> restaurantDetails = RestaurantBusinessLogic.RestaurantDetails();
            return View("RestaurantDetails", restaurantDetails);
            
        }
    
        public ActionResult AddRestaurant()
        {
            return View();
        }  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddRestaurant(RestaurantViewModel restaurantVm)
        {
            if (ModelState.IsValid)
            {
                //RestaurantRepository.CreateRestaurantDb();
                Restaurant restaurant = new Restaurant();
                restaurant.RestaurantId = restaurantVm.RestaurantId;
                restaurant.Name = restaurantVm.Name;
                restaurant.Description = restaurantVm.Description;
                restaurant.City = restaurantVm.City.ToString();
                restaurant.Alcohol = restaurantVm.Alcohol;
                restaurant.Services = restaurantVm.Services;
                restaurant.Cuisine = restaurantVm.Cuisine.ToString();
                restaurant.WorkingDays = restaurantVm.WorkingDays;
                restaurant.OpeningTime = restaurantVm.OpeningTime;
                restaurant.ClosingTime = restaurantVm.ClosingTime;
                restaurant.Email = restaurantVm.Email;
                restaurant.RestaurantWebsite = restaurantVm.RestaurantWebsite;
                restaurant.PhoneNumber = restaurantVm.PhoneNumber;
                restaurant.CreatedTime = DateTime.Now;              
                RestaurantBusinessLogic.AddRestaurant (restaurant);
                return RedirectToAction("Index");
            }
            return View();

        }
        public ActionResult ViewRestaurants()
        {
            IEnumerable<Restaurant> restaurantDetails = RestaurantBusinessLogic.RestaurantDetails();
            ViewBag.restaurants = restaurantDetails;
            ViewData["Restaurants"] = restaurantDetails;
            TempData["Restaurants"] = restaurantDetails;
            return View();
        }
        public ActionResult Edit(int id)
        {
            Restaurant restaurant = RestaurantBusinessLogic.RestaurantById(id);
            return View(restaurant);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(RestaurantViewModel restaurantVm)
        {
            

            Restaurant restaurant = new Restaurant();
          //  restaurant.Id = restaurantVm.Id;
            restaurant.Name = restaurantVm.Name;
            restaurant.Description = restaurantVm.Description;
            restaurant.City = restaurantVm.City.ToString();
            restaurant.Alcohol = restaurantVm.Alcohol;
            restaurant.Services = restaurantVm.Services;
            restaurant.Cuisine = restaurantVm.Cuisine.ToString();
            restaurant.WorkingDays = restaurantVm.WorkingDays;
            restaurant.OpeningTime = restaurantVm.OpeningTime.ToString();
            restaurant.ClosingTime = restaurantVm.ClosingTime;
            restaurant.Email = restaurantVm.Email;
            restaurant.RestaurantWebsite = restaurantVm.RestaurantWebsite;
            restaurant.PhoneNumber = restaurantVm.PhoneNumber;
            restaurant.CreatedTime = DateTime.Now;
            RestaurantBusinessLogic.UpdateRestaurant(restaurant);
            //TempData["Message"] = "Updated Succesfully";
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id)
        {
            RestaurantBusinessLogic.DeleteRestaurant(id);
           // TempData["Message"] = "Deleted Succesfully";
            return RedirectToAction("Index");
        }
    }
}