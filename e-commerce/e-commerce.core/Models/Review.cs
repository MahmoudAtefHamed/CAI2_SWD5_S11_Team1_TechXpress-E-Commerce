using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Site_User")]
        public int User_Id { get; set; }
        [ForeignKey("Order_Line")]
        public int Ordered_Product_Id { get; set; }
        public int Rating_Value { get; set; }
        public string? Comment { get; set; }


        public virtual Site_User? Site_User { get; set; }
        public virtual Order_Line? Order_Line { get; set; }
        public virtual Product_Item? Product_Item { get; set; }
    }
}
