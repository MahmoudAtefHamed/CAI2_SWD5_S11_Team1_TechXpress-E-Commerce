using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models
{
    public class Variation_Option
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Variation")]
        public int Variation_Id { get; set; }
        public decimal Value { get; set; }

        public virtual Variation? Variation { get; set; }
        public virtual List<Product_Configuration>? Product_Configurations { get; set; }
    }
}
