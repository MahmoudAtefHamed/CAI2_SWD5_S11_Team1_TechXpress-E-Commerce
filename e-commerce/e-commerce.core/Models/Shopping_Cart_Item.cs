using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models
{
    public class Shopping_Cart_Item
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Shopping_Cart")]
        public int Cart_Id { get; set; }
        [ForeignKey("Product_Item")]
        public int Product_Item_Id { get; set; }
        public int Qty { get; set; }

        public virtual Shopping_Cart? Shopping_Cart { get; set; }   
        public virtual Product_Item? Product_Item { get; set; }

    }
}
