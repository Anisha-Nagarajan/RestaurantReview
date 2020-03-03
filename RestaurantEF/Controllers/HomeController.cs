
using System.Web.Mvc;

namespace RestaurantEF.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       // [OutputCache(Duration=10)]
        public ActionResult Index()
        {
            return View();
        }
    }
}