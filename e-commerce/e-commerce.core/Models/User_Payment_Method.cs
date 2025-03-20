using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models
{
    public class User_Payment_Method
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Site_User")]
        public int User_Id { get; set; }
        [ForeignKey("Payment_Type")]
        public int Payment_Type_Id { get; set; }

        public string Provider {  get; set; }
        public string Account_Number    { get; set; }

        public DateTime ExpiryDate { get; set; }
        public bool IsDefault { get; set; }
        public virtual Site_User? Site_User { get; set; }
        public virtual Payment_Type? Payment_Type { get; set; }

    }
}
