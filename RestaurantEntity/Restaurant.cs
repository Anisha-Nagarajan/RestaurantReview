using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.DynamicData;

namespace RestaurantEntity
{
    [TableName("tblRestaurants")]
    public class Restaurant
    {

        [Key]
        public int RestaurantId { get; set; }

        [Required(ErrorMessage = "Name is Required. It cannot be empty")]
       // [RegularExpression(@"[a-zA-Z0-9\s]*$", ErrorMessage = "Only Alphabets,Numbers and Spaces allowed.")]
        [StringLength(40, ErrorMessage = "The Name must contain a maximum of 30 characters", MinimumLength = 4)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is Required. It cannot be empty")]
      //  [RegularExpression(@"[a-zA-Z0-9\s]*$", ErrorMessage = "Only Alphabets,Numbers and Spaces allowed.")]
        [MaxLength(500), MinLength(4)]
        public string Description { get; set; }

        [Required(ErrorMessage = "City is Required. It cannot be empty")]
        [MaxLength(30), MinLength(3)]
        public string City { get; set; }

        [Required(ErrorMessage = "Alcohol Field is Required. It cannot be empty")]
        [MaxLength(30), MinLength(3)]
        public string Alcohol { get; set; }

        [Required(ErrorMessage = "Services is Required. It cannot be empty")]
        [MaxLength(30), MinLength(3)]
        public string Services { get; set; }

        [Required(ErrorMessage = "Cuisines is Required. It cannot be empty")]
        [StringLength(500)]
        public string Cuisine{ get; set; }

        [Required(ErrorMessage = "Working Days is Required. It cannot be empty")]
        [StringLength(500)]
        public string WorkingDays { get; set; }

        [Required(ErrorMessage = "Opening Time is Required. It cannot be empty")]
        [MaxLength(30), MinLength(3)]
        //[DataType(DataType.Time)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public string OpeningTime { get; set; }

        [Required(ErrorMessage = "Closing Time is Required. It cannot be empty")]
        [MaxLength(30), MinLength(3)]
        //[DataType(DataType.Time)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public string ClosingTime { get; set; }

        [Required(ErrorMessage = "Email is Required. It cannot be empty")]
        [StringLength(500)]
        [Index(IsUnique = true)]
        public string Email { get; set; }

        [StringLength(500)]
        public string RestaurantWebsite { get; set; }

        [Required(ErrorMessage = "PhoneNumber is Required. It cannot be empty")]
        [DataType(DataType.PhoneNumber)]
        [Index(IsUnique = true)]
        public long PhoneNumber { get; set; }

        public DateTime CreatedTime { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }

    }
}
