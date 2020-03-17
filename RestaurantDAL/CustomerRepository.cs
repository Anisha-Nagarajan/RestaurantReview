
using System.Collections.Generic;
using System.Linq;
using RestaurantEntity;

namespace RestaurantDAL
{
   public class CustomerRepository : ICustomerRepository
    {
       
        public  IEnumerable<Customer> CreateCustomerDb()
        {
            IEnumerable<Customer> customerDetails;
            using (var restaurantDb = new RestaurantDbContext())
            {
                customerDetails= restaurantDb.Customers.ToList();
            }
            return customerDetails;
        }

        public void AddCustomer(Customer customer)
        {
            using (var restaurantDb = new RestaurantDbContext())
            {
                restaurantDb.Customers.Add(customer);
                restaurantDb.SaveChanges();
            }
        }
     
        public string CheckLogin(Customer customer)
        {
            // bool loginStatus = false;
            string userRole = "";
            using (var restaurantDb = new RestaurantDbContext())
            {
                
                foreach (var cus in restaurantDb.Customers)
                {
                    if ((cus.Name.Equals(customer.Name)) && (cus.Password.Equals(customer.Password)))
                    {
                        userRole = cus.Role;
                        //loginStatus = true;
                        break;
                    }
                }
            }
            return userRole;
        }
    }
}
