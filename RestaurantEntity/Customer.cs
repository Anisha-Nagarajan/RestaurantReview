
using System.ComponentModel.DataAnnotations;

namespace RestaurantEntity
{
   public class Customer
    {
       
        
        //[Required(ErrorMessage = "Id is Required. It cannot be empty")]
        [Key]
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required. It cannot be empty")]
       
        [StringLength(30, ErrorMessage = "The Name must contain a maximum of 30 characters", MinimumLength = 4)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Password is Required. It cannot be empty")]
       
        public string Password { get; set; }
        //[Required(ErrorMessage = "Confirmation Password is required.")]

        //[Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        //public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email is Required. It cannot be empty")]
       
        public string Email { get; set; }
        [Required(ErrorMessage = "Gender is Required. It cannot be empty")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Address is Required. It cannot be empty")]

        public string Address { get; set; }
        [Required(ErrorMessage = "City is Required. It cannot be empty")]

        public string City { get; set; }
        [Required(ErrorMessage = "PhoneNumber is Required. It cannot be empty")]
       
        public long PhoneNumber { get; set; }

        [Required(ErrorMessage = "Role is Required. It cannot be empty")]
        public string Role { get; set; }
    }
}
