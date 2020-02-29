using RestaurantDAL;
using RestaurantEntity;

namespace RestaurantBL
{
    public class CustomerBusinessLogic
    {
        public CustomerRepository customerRepository = new CustomerRepository();
        public static bool LoginData(Customer customer)
        {
            bool loginStatus = CustomerRepository.CheckLogin(customer);
            return loginStatus;
        }
        public static void SignUpData(Customer customer)
        {
            CustomerRepository.AddCustomer(customer);
        }
    }
}
