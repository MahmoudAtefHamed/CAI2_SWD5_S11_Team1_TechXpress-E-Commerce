using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models
{
    public class User_Address
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Site_User")]
        public int User_Id { get; set; }
        [ForeignKey("Address")]
        public int Address_Id { get; set; }
        public bool IsDefault { get; set; }
        public virtual Site_User? Site_User { get; set; }
        public virtual Address? Address { get; set; }
    }
}
