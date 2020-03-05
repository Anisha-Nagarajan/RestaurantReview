using RestaurantEntity;
using System.Web.Mvc;
using RestaurantEF.ViewModels;
using RestaurantBL;
using System;

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
        public ActionResult Login(LoginViewModel customerVm)
        {
            Customer customer = new Customer();
            customer.Name = customerVm.Name;
            customer.Password = customerVm.Password;
          
            string userRole = CustomerBusinessLogic.LoginData(customer);
           
                if (userRole.Equals("Customer"))
                    return RedirectToAction("ViewRestaurants", "Restaurant");
                else if(userRole.Equals("Restaurant Owner"))
                    return RedirectToAction("Index", "Home");
                else
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
                //customer.ConfirmPassword = customerVm.ConfirmPassword;
                customer.Email = customerVm.Email;
                customer.Gender = customerVm.Gender;
                customer.Address = customerVm.ConfirmPassword;
                customer.City = customerVm.City.ToString();
                customer.PhoneNumber = customerVm.PhoneNumber;
                customer.Role = customerVm.Role;
                customer.CreatedTime = DateTime.Now;
                CustomerBusinessLogic.SignUpData(customer);
             
                 return RedirectToAction("Login");
            }
           
                return View();
       }

    }
}