using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
    public class Site_User
    {
        [Key]
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }


        public virtual List<User_Address>? User_Addresses { get; set; }
        public virtual List<User_Payment_Method>? User_Payment_Methods  { get; set; }
        public virtual List<Review>? Reviews { get; set; }
        public virtual List<Shop_Order>? Shop_Orders { get; set; }

    }
}
