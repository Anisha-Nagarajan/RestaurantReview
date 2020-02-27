
using System.Web.Mvc;
using RestaurantDAL;
using RestaurantEntity;
using System.Collections.Generic;

namespace RestaurantEF.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Index()
        {
            IEnumerable<Restaurant> RestaurantDetails = RestaurantRepository.CreateRestaurantDb();
            return View("RestaurantDetails", RestaurantDetails);
            
        }
        public ActionResult AddRestaurant()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddRestaurant(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                RestaurantRepository.CreateRestaurantDb();
                RestaurantRepository.AddRestaurants(restaurant);
                return RedirectToAction("Index");
            }
            return View();

        }
        public ActionResult ViewRestaurants()
        {
            IEnumerable<Restaurant> RestaurantDetails = RestaurantRepository.CreateRestaurantDb();
            ViewBag.restaurants = RestaurantDetails;
            ViewData["Restaurants"] = RestaurantDetails;
            TempData["Restaurants"] = RestaurantDetails;
            return View();
        }
        public ActionResult Edit(int id)
        {
            Restaurant restaurant = RestaurantRepository.GetRestaurantById(id);
            return View(restaurant);
        }

        [HttpPost]
        public ActionResult Update(Restaurant restaurant)
        {
            RestaurantRepository.Update(restaurant);
         //   TempData["Message"] = "Updated Succesfully";
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id)
        {
            RestaurantRepository.Delete(id);
           // TempData["Message"] = "Deleted Succesfully";
            return RedirectToAction("Index");
        }
    }
}