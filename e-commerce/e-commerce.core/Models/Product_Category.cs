using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models
{
    public class Product_Category
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("product_category")]
        public int? Parent_Category_Id { get; set; }
        public string Category_Name { get; set; }

        public virtual Product_Category? product_category { get; set; }
        public virtual List<Product>? Products { get; set; }
        public virtual List<Promotion_Category>? Promotion_Categories { get; set; }
        public virtual List<Variation_Option>? Variation_Options { get; set; }



    }
}
