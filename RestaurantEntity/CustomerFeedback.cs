using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEntity
{
    public class CustomerFeedback
    {
        [Key]
        [Required(ErrorMessage = "Restaurant Name is Required. It cannot be empty")]
        [Display(Name ="Restaurant Name")]
        public string RestaurantName { get; set; }
        [Required(ErrorMessage = "Food Quality is Required. It cannot be empty")]
        [Display(Name = "Food Quality")]
        public string FoodQuality { get; set; }
        [Required(ErrorMessage = "Overall Service Quality is Required. It cannot be empty")]
        [Display(Name = "Overall Service Quality")]
        public string OverallServiceQuality { get; set; }
        [Required(ErrorMessage = "Cleanlinessis Required. It cannot be empty")]
        public string Cleanliness { get; set; }
        [Required(ErrorMessage = "Orde rAccuracy is Required. It cannot be empty")]
        [Display(Name = "Order Accuracy")]
        public string OrderAccuracy { get; set; }
        [Required(ErrorMessage = "Speed Of Service is Required. It cannot be empty")]
        [Display(Name = "Speed Of Service")]
        public string SpeedOfService { get; set; }
        [Required(ErrorMessage = "Price is Required. It cannot be empty")]
        public string Price { get; set; }
        [Required(ErrorMessage = "Overall Experience is Required. It cannot be empty")]
        [Display(Name = "Overall Experience")]
        public string OverallExperience { get; set; }
    }
}
