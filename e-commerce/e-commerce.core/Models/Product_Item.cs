using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models
{
    public class Product_Item
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public string SKU { get; set; }
        public int Qty_In_Stock { get; set; }
        public string Product_Image { get; set; }
        public decimal Price { get; set; }


        public virtual Product? Product { get; set; }
        public virtual List<Shopping_Cart_Item>? Shopping_Cart_Items { get; set; }
        public virtual List<Product_Configuration>? Product_Configurations { get; set; }
        public virtual List<Order_Line>? Order_Lines { get; set; }
        public virtual List<Review>? Reviews { get; set; }





    }
}
