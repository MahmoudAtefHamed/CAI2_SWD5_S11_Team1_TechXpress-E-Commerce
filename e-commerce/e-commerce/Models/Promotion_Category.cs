using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models
{
    public class Promotion_Category
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Promotion")]
        public int Promotion_Id { get; set; }
        [ForeignKey("Product_Category")]
        public int Category_Id { get; set; }

        public virtual Promotion? Promotion { get; set; }
        public virtual Product_Category? Product_Category { get; set; }

    }
}
