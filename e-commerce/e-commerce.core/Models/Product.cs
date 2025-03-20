using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Product_Category")]
        public int Category_Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Product_Image {  get; set; }

        public virtual Product_Category? Product_Category { get; set; }
        public virtual List<Product_Item>? Product_Items { get; set; }
        public virtual List<Promotion_Category>? Promotion_Categories { get; set; }
    }
}
