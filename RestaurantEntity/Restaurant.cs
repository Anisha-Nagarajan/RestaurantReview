using System;
using System.ComponentModel.DataAnnotations;

namespace RestaurantEntity
{
    public class Restaurant
    {
        [Required(ErrorMessage = "Id is Required. It cannot be empty")]
        [Range(1, 99999, ErrorMessage = "Id Should be min 1 and max 99999")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required. It cannot be empty")]
        [RegularExpression(@"[a-zA-Z0-9\s]*$", ErrorMessage = "Only Alphabets,Numbers and Spaces allowed.")]
        [StringLength(40, ErrorMessage = "The Name must contain a maximum of 30 characters", MinimumLength = 4)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is Required. It cannot be empty")]
        [RegularExpression(@"[a-zA-Z0-9\s]*$", ErrorMessage = "Only Alphabets,Numbers and Spaces allowed.")]
        public string Description { get; set; }

        public string City { get; set; }

        public string Alcohol { get; set; }

        public string Services { get; set; }

        public string Cuisines { get; set; }

        public string WorkingDays { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime OpeningTime { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime ClosingTime { get; set; }

        public string Email { get; set; }

        public string RestaurantWebsite { get; set; }

        public DateTime CreatedTime { get; set; }

    }
}
