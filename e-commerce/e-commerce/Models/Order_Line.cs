using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models
{
    public class Order_Line
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Product_Item")]
        public int Product_Item_Id { get; set; }
        [ForeignKey("Shop_Order")]
        public int Order_Id { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }

        public virtual Product_Item? Product_Item { get; set; }
        public virtual Shop_Order? Shop_Order { get; set; }


    }
}
