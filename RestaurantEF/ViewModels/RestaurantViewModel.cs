using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantEF.ViewModels
{
    public class RestaurantViewModel
    {

        [Required(ErrorMessage = "Id is Required. It cannot be empty")]
        [Range(1, 99999, ErrorMessage = "Id Should be min 1 and max 99999")]
        [Display(Name ="Restaurant Id")]
        public int Id { get; set; }
       
        [Required(ErrorMessage = "Name is Required. It cannot be empty")]
        [RegularExpression(@"[a-zA-Z0-9\s]*$", ErrorMessage = "Only Alphabets,Numbers and Spaces allowed.")]
        [StringLength(40, ErrorMessage = "The Name must contain a maximum of 30 characters", MinimumLength = 4)]
        [Display(Name = "Restaurant Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is Required. It cannot be empty")]
        [RegularExpression(@"[a-zA-Z0-9\s]*$", ErrorMessage = "Only Alphabets,Numbers and Spaces allowed.")]
        public string Description { get; set; }
        
    }
}