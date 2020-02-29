using RestaurantEntity;
using System.Web.Mvc;
using RestaurantDAL;
using RestaurantEF.ViewModels;
using static RestaurantEntity.Customer;
using System;
using RestaurantBL;

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
        public ActionResult Login(CustomerViewModel customerVm)
        {
            Customer customer = new Customer();
            customer.Name = customerVm.Name;
            customer.Password = customerVm.Password;
            bool loginStatus = CustomerBusinessLogic.LoginData(customer);
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
        public ActionResult SignUp(CustomerViewModel customerVm)
        {
            if (ModelState.IsValid)
            {
                Customer customer = new Customer();
                customer.Id = customerVm.Id;
                customer.Name = customerVm.Name;
                customer.Password = customerVm.Password;
                customer.ConfirmPassword = customerVm.ConfirmPassword;
                customer.Email = customerVm.Email;
                customer.Gender = customerVm.Gender;
                customer.Address = customerVm.ConfirmPassword;
                customer.City = (CustomerCity)Enum.ToObject(typeof(CustomerCity),customerVm.City);
                customer.PhoneNumber = customerVm.PhoneNumber;
                CustomerBusinessLogic.SignUpData(customer);
             
                 return RedirectToAction("Login");
            }
           
                return View();
       }

    }
}