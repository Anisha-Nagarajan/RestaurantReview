using RestaurantEntity;
using System.Collections.Generic;

namespace RestaurantDAL
{
   public interface ICustomerRepository
    {
        IEnumerable<Customer> CreateCustomerDb();
        void AddCustomer(Customer customer);
        string CheckLogin(Customer customer);

    }
}
