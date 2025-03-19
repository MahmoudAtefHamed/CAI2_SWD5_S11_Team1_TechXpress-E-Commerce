using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models
{
    public class Variation
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Product_Category")]
        public int Category_Id { get; set; }
        public string Name { get; set; }
        public virtual Product_Category? Product_Category { get; set; }
    }
}
