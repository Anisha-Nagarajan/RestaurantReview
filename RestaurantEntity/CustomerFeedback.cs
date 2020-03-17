using System.ComponentModel.DataAnnotations;
using System.Web.DynamicData;

namespace RestaurantEntity
{
    [TableName("tblfeedbacks")]
    public class CustomerFeedback
    {
        [Key]
        [Required(ErrorMessage = "Restaurant Name is Required. It cannot be empty")]
        [StringLength(30, ErrorMessage = "The Restaurant Name must contain a maximum of 30 characters", MinimumLength = 3)]
        [Display(Name ="Restaurant Name")]
        public string RestaurantName { get; set; }
        [Required(ErrorMessage = "Food Quality is Required. It cannot be empty")]
        [StringLength(30, ErrorMessage = "The FoodQuality must contain a maximum of 30 characters", MinimumLength = 3)]
        [Display(Name = "Food Quality")]
        public string FoodQuality { get; set; }
        [Required(ErrorMessage = "Overall Service Quality is Required. It cannot be empty")]
        [StringLength(30, ErrorMessage = "The OverallServiceQuality must contain a maximum of 30 characters", MinimumLength = 3)]
        [Display(Name = "Overall Service Quality")]
        public string OverallServiceQuality { get; set; }
        [Required(ErrorMessage = "Cleanlinessis Required. It cannot be empty")]
        [StringLength(30, ErrorMessage = "The Cleanliness must contain a maximum of 30 characters", MinimumLength = 3)]
        public string Cleanliness { get; set; }
        [Required(ErrorMessage = "OrderAccuracy is Required. It cannot be empty")]
        [StringLength(30, ErrorMessage = "The OrderAccuracy must contain a maximum of 30 characters", MinimumLength = 3)]
        [Display(Name = "Order Accuracy")]
        public string OrderAccuracy { get; set; }
        [Required(ErrorMessage = "Speed Of Service is Required. It cannot be empty")]
        [StringLength(30, ErrorMessage = "The SpeedOfService must contain a maximum of 30 characters", MinimumLength = 3)]
        [Display(Name = "Speed Of Service")]
        public string SpeedOfService { get; set; }
        [Required(ErrorMessage = "Price is Required. It cannot be empty")]
        [StringLength(8, ErrorMessage = "The Price must contain a maximum of 8 characters", MinimumLength = 1)]
        public string Price { get; set; }
        [Required(ErrorMessage = "Overall Experience is Required. It cannot be empty")]
        [StringLength(30, ErrorMessage = "The OverallExperience must contain a maximum of 30 characters", MinimumLength = 3)]
        [Display(Name = "Overall Experience")]
        public string OverallExperience { get; set; }

      
    }
}
