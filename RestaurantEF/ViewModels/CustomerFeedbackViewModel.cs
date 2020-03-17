using System.ComponentModel.DataAnnotations;

namespace RestaurantEF.ViewModels
{
    public class CustomerFeedbackViewModel
    {
        [Key]
        [Required(ErrorMessage = "Restaurant Name is Required. It cannot be empty")]
        public string RestaurantName { get; set; }
        [Required(ErrorMessage = "Food Quality is Required. It cannot be empty")]
        public string FoodQuality { get; set; }
        [Required(ErrorMessage = "Overall Service Quality is Required. It cannot be empty")]
        public string OverallServiceQuality { get; set; }
        [Required(ErrorMessage = "Cleanlinessis Required. It cannot be empty")]
        public string Cleanliness { get; set; }
        [Required(ErrorMessage = "Orde rAccuracy is Required. It cannot be empty")]
        public string OrderAccuracy { get; set; }
        [Required(ErrorMessage = "Speed Of Service is Required. It cannot be empty")]
        public string SpeedOfService { get; set; }
        [Required(ErrorMessage = "Price is Required. It cannot be empty")]
        public string Price { get; set; }
        [Required(ErrorMessage = "Overall Experience is Required. It cannot be empty")]
        public string OverallExperience { get; set; }
    }
}