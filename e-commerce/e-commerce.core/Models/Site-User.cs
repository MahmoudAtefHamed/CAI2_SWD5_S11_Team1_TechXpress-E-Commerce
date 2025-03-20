using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
    public class Site_User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$",ErrorMessage ="Invalid Email")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required]
        [RegularExpression("^(\\+201|01|00201)[0-2,5]{1}[0-9]{8}", ErrorMessage ="Invalid Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [MinLength(6,ErrorMessage ="Must be at least 6 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        public virtual List<User_Address>? User_Addresses { get; set; }
        public virtual List<User_Payment_Method>? User_Payment_Methods  { get; set; }
        public virtual List<Review>? Reviews { get; set; }
        public virtual List<Shop_Order>? Shop_Orders { get; set; }

    }
}
