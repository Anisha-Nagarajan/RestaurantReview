
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.DynamicData;

namespace RestaurantEntity
{
    [TableName("tblCustomers")]
    public class Customer
    {


        //[Required(ErrorMessage = "Id is Required. It cannot be empty")]
        [Key]

        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Name is Required. It cannot be empty")]
        [StringLength(30, ErrorMessage = "The Name must contain a maximum of 30 characters", MinimumLength = 3)]

        public string Name { get; set; }
        [Required(ErrorMessage = "Password is Required. It cannot be empty")]

        [StringLength(20, ErrorMessage = "The Password must contain a maximum of 20 characters", MinimumLength = 4)]
        public string Password { get; set; }
        //[Required(ErrorMessage = "Confirmation Password is required.")]

        //[Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        //public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email is Required. It cannot be empty")]
        [MaxLength(70), MinLength(7)]
        [Index(IsUnique =true)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Gender is Required. It cannot be empty")]
        public string Gender { get; set; }
        [StringLength(80, ErrorMessage = "The Address must contain a maximum of 80 characters", MinimumLength = 4)]
        [Required(ErrorMessage = "Address is Required. It cannot be empty")]

        public string Address { get; set; }
        [Required(ErrorMessage = "City is Required. It cannot be empty")]
        [StringLength(30, ErrorMessage = "The City must contain a maximum of 30 characters", MinimumLength = 3)]

        public string City { get; set; }

        [Required(ErrorMessage = "PhoneNumber is Required. It cannot be empty")]
        [DataType(DataType.PhoneNumber)]
        [Index(IsUnique = true)]
        public long PhoneNumber { get; set; }

        [Required(ErrorMessage = "Role is Required. It cannot be empty")]
        [StringLength(20, ErrorMessage = "The Role must contain a maximum of 20 characters", MinimumLength = 5)]
        public string Role { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "CreatedTime is Required. It cannot be empty")]
        public DateTime CreatedTime{get;set;}

        public int? RestaurantId { get; set; }
        [ForeignKey("RestaurantId")]
        public virtual Restaurant Restautant { get; set; }
    }

}