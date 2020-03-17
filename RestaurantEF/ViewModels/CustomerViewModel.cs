using RestaurantEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantEF.ViewModels
{
    public class CustomerViewModel
    {
        public enum CustomerCity
        {

            Salem,
            Namakkal,
            Erode,
            Tiruchengode,
            Coimbatore,
            Chennai
        }
       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity),Key()] 
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Name is Required. It cannot be empty")]
        [RegularExpression(@"[a-zA-Z0-9\s]*$", ErrorMessage = "Only Alphabets,Numbers and Spaces allowed.")]
        [StringLength(30, ErrorMessage = "The Name must contain a maximum of 30 characters", MinimumLength = 4)]
        [Display(Name ="User Name")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Password is Required. It cannot be empty")]
        //     [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Only Alphabets allowed.")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirmation Password is required.")]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        [Display(Name ="Confirm Password")]

        public string ConfirmPassword { get; set; }

       [Required(ErrorMessage = "Email is Required. It cannot be empty")]
       [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
        ErrorMessage = "Please Enter Correct Email Address")]
        [Display(Name ="Email Id")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Gender is Required. It cannot be empty")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Address is Required. It cannot be empty")]
     
        public string Address { get; set; }

        [Required(ErrorMessage = "City is Required. It cannot be empty")]

        public CustomerCity City { get; set; }
        [Required(ErrorMessage = "PhoneNumber is Required. It cannot be empty")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Phone number")]
        [Display(Name ="Phone Number")]

        public long PhoneNumber { get; set; }

        [Required(ErrorMessage = "Role is Required. It cannot be empty")]
        public string Role { get; set; }

        public int? RestaurantId { get; set; }
        [ForeignKey("RestaurantId")]
        public virtual Restaurant Restautant { get; set; }
    }
}
