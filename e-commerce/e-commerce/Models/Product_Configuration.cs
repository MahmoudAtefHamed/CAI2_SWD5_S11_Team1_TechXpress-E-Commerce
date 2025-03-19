using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models
{
    public class Product_Configuration
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Product_Item")]
        public int Product_Item_Id { get; set; }
        [ForeignKey("Variation_Option")]
        public int Variation_Option_Id { get; set; }

        public virtual Product_Item? Product_Item { get; set; }
        public virtual Variation_Option? Variation_Option { get; set; }

    }
}
