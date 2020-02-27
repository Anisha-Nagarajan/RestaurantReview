namespace RestaurantEntity
{
   public class Customer
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
       // [Required(ErrorMessage = "Id is Required. It cannot be empty")]

        public int Id { get; set; }
      //  [Required(ErrorMessage = "Name is Required. It cannot be empty")]
      //  [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
      //  //[StringLength(30, ErrorMessage = "The Name must contain a maximum of 30 characters", MinimumLength = 4)]
        public string Name { get; set; }
      //  [Required(ErrorMessage = "Password is Required. It cannot be empty")]
        public string Password { get; set; }
      //  [Required(ErrorMessage = "Confirmation Password is required.")]
    //    [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        public string ConfirmPassword { get; set; }
    //    [Required(ErrorMessage = "Email is Required. It cannot be empty")]
   //     [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
    //    ErrorMessage = "Please Enter Correct Email Address")]
        public string Email { get; set; }
    //    [Required(ErrorMessage = "Gender is Required. It cannot be empty")]
        public string Gender { get; set; }
   //     [Required(ErrorMessage = "Address is Required. It cannot be empty")]
   //     [RegularExpression(@"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$", ErrorMessage = "Invalid City Name")]
        public string Address { get; set; }
  //      [Required(ErrorMessage = "City is Required. It cannot be empty")]

        public CustomerCity City { get; set; }
     //   [Required(ErrorMessage = "PhoneNumber is Required. It cannot be empty")]
     //   [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Phone number")]
    //    //[MaxLength(10, ErrorMessage = "The Mobile must contains 10 characters")]
        public long PhoneNumber { get; set; }
    }
}
