using RestaurantDAL;
using RestaurantEntity;

namespace RestaurantBL
{
    public class CustomerBusinessLogic
    {

        public static CustomerRepository customerRepository = new CustomerRepository();
        public static string LoginData(Customer customer)
        {
           // CustomerRepository customerRepository = new CustomerRepository();
            string userRole = customerRepository.CheckLogin(customer);

            return userRole;
        }
        public static void SignUpData(Customer customer)
        {
           // CustomerRepository customerRepository = new CustomerRepository();
         customerRepository.AddCustomer(customer);
        }
        public static string Encryptpass(string password)
        {
          string encryptedPassword=Security.Encryptpass(password);
           return encryptedPassword;
        }
        public static string Decryptpass(string encryptedPassword)
        {
           string decryptedPassword= Security.Encryptpass(encryptedPassword);
           return decryptedPassword;
        }
    }
}
