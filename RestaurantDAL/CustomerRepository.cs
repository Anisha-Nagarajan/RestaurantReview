
using System.Collections.Generic;
using System.Linq;
using RestaurantEntity;

namespace RestaurantDAL
{
   public class CustomerRepository
    {
        public static IEnumerable<Customer> CreateCustomerDb()
        {
            RestaurantDbContext restaurantDb = new RestaurantDbContext();
            return restaurantDb.Customers.ToList();
        }
        public static void AddCustomer(Customer customer)
        {
            RestaurantDbContext restaurantDb = new RestaurantDbContext();
            restaurantDb.Customers.Add(customer);
            restaurantDb.SaveChanges();
        }
     
        public static bool CheckLogin(Customer customer)
        {
            bool loginStatus = false;
            RestaurantDbContext restaurantDb = new RestaurantDbContext();
            foreach (var cus in restaurantDb.Customers)
            {
                if ((cus.Name.Equals(customer.Name)) && (cus.Password.Equals(customer.Password)))
                {
                    loginStatus = true;
                    break;
                }
            }

            return loginStatus;
        }
    }
}
