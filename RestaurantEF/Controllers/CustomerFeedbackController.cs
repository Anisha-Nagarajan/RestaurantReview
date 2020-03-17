using RestaurantEF.ViewModels;
using RestaurantEntity;
using System.Web.Mvc;
using RestaurantBL;

namespace RestaurantEF.Controllers
{
    public class CustomerFeedbackController : Controller
    {
        // GET: CustomerFeedback
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddFeedback()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddFeedback(CustomerFeedbackViewModel feedbackVm)
        {
            if (ModelState.IsValid)
            {
                CustomerFeedback feedback = new CustomerFeedback();
                feedback.RestaurantName = feedbackVm.RestaurantName;
                feedback.FoodQuality = feedbackVm.FoodQuality;
                feedback.OverallServiceQuality = feedbackVm.OverallServiceQuality;
                feedback.Cleanliness = feedbackVm.Cleanliness;
                feedback.OrderAccuracy = feedbackVm.OrderAccuracy;
                feedback.SpeedOfService = feedbackVm.SpeedOfService;
                feedback.Price = feedbackVm.Price;
                feedback.OverallExperience = feedbackVm.OverallExperience;
                FeedbackBusinessLogic.AddFeedback(feedback);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}