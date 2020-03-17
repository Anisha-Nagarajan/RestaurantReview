
using RestaurantEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantEF.ViewModels
{
    public class RestaurantViewModel
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
        public enum Cuisines
        {
            SouthIndian,
            NorthIndian,
            Kashmiri,
            Mughlai,
            Punjabi,
            Rajasthani,
            Chettinad,
            Bihari,
            Bhojpuri,
            AngloIndian
        }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        [Display(Name = "Restaurant Id")]
        public int RestaurantId { get; set; }

        [Required(ErrorMessage = "Name is Required. It cannot be empty")]
        [RegularExpression(@"[a-zA-Z0-9\s]*$", ErrorMessage = "Only Alphabets,Numbers and Spaces allowed.")]
        [StringLength(40, ErrorMessage = "The Name must contain a maximum of 30 characters", MinimumLength = 4)]
        [Display(Name = "Restaurant Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is Required. It cannot be empty")]
        [RegularExpression(@"[a-zA-Z0-9\s]*$", ErrorMessage = "Only Alphabets,Numbers and Spaces allowed.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "City is Required. It cannot be empty")]
    
        public CustomerCity City { get; set; }

        [Required(ErrorMessage = "Alcohol Field is Required. It cannot be empty")]
        public string Alcohol { get; set; }

        [Required(ErrorMessage = "Services is Required. It cannot be empty")]
        public string Services { get; set; }

        [Required(ErrorMessage = "Cuisines is Required. It cannot be empty")]
     
        public Cuisines Cuisine { get; set; }

        [Required(ErrorMessage = "Working Days is Required. It cannot be empty")]
      
        public string WorkingDays { get; set; }
       
        [Required(ErrorMessage = "Opening Time is Required. It cannot be empty")]
        //[DataType(DataType.Time)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public string OpeningTime { get; set; }

        [Required(ErrorMessage = "Closing Time is Required. It cannot be empty")]
        //[DataType(DataType.Time)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public string ClosingTime { get; set; }

        [Required(ErrorMessage = "Email is Required. It cannot be empty")]
      
        public string Email { get; set; }

    
        public string RestaurantWebsite { get; set; }

        [Required(ErrorMessage = "PhoneNumber is Required. It cannot be empty")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Phone number")]
        [Display(Name = "Phone Number")]
        public long PhoneNumber { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}