using RestaurantEntity;
using System.Web.Mvc;
using RestaurantDAL;

namespace RestaurantEF.Controllers
{
    public class AccountController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
    //    [Authorize]
        public ActionResult Login(Customer customer)
        {
            bool loginStatus = CustomerRepository.CheckLogin(customer);
            if (loginStatus)
                return RedirectToAction("Index", "Restaurant");

            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        [HandleError(View="Error.cshtml")]
        public ActionResult SignUp(Customer customer)
        {
            if (ModelState.IsValid)
            {
                CustomerRepository.AddCustomer(customer);
             
                 return RedirectToAction("Login");
            }
           
                return View();
       }

    }
}