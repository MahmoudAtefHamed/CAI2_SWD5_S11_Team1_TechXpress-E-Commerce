using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models
{
    public class Shopping_Cart
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Site_User")]
        public int User_Id { get; set; }
        public virtual Site_User? Site_User { get; set; }
        public virtual List<Shopping_Cart_Item>? Shopping_Cart_Items { get; set; }

    }
}
