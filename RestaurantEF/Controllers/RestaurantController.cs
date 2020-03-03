using System.Web.Mvc;
using RestaurantEntity;
using System.Collections.Generic;
using RestaurantEF.ViewModels;
using RestaurantBL;

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
        public ActionResult AddRestaurant(RestaurantViewModel restaurantVm)
        {
            if (ModelState.IsValid)
            {
                //RestaurantRepository.CreateRestaurantDb();
                Restaurant restaurant = new Restaurant();
                restaurant.Id = restaurantVm.Id;
                restaurant.Name = restaurantVm.Name;
                restaurant.Description = restaurantVm.Description;
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
        public ActionResult Update(RestaurantViewModel restaurantVm)
        {
            Restaurant restaurant = new Restaurant();
            restaurant.Id = restaurantVm.Id;
            restaurant.Name = restaurantVm.Name;
            restaurant.Description = restaurantVm.Description;
            RestaurantBusinessLogic.UpdateRestaurant(restaurant);
         //   TempData["Message"] = "Updated Succesfully";
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