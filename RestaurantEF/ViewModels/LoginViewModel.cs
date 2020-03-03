using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantEF.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Name is Required. It cannot be empty")]
        [RegularExpression(@"[a-zA-Z0-9\s]*$", ErrorMessage = "Only Alphabets,Numbers and Spaces allowed.")]
        [StringLength(30, ErrorMessage = "The Name must contain a maximum of 30 characters", MinimumLength = 4)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Password is Required. It cannot be empty")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string Password { get; set; }
    }
}