using RestaurantDAL;
using RestaurantEntity;

namespace RestaurantBL
{
    public class CustomerBusinessLogic
    {

        public CustomerRepository customerRepository = new CustomerRepository();
        public static string LoginData(Customer customer)
        {

            string userRole = CustomerRepository.CheckLogin(customer);

            return userRole;
        }
        public static void SignUpData(Customer customer)
        {
            CustomerRepository.AddCustomer(customer);
        }
    }
}
