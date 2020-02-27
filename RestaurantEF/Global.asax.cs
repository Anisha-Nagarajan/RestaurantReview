using RestaurantDAL;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;

namespace RestaurantEF
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer<RestaurantDbContext>(new DropCreateDatabaseIfModelChanges<RestaurantDbContext>());
         //   Database.SetInitializer<RestaurantDbContext>(null);
        }
    }
}
