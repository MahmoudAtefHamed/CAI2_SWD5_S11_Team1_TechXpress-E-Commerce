using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
    public class Shipping_Method
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public virtual List<Shop_Order>? Shop_Orders { get; set; }



    }
}
