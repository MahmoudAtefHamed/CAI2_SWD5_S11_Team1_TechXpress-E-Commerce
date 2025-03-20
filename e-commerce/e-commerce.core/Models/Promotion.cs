using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
    public class Promotion
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Discount_Rate { get; set; }
        public DateTime Start_Date { get; } = DateTime.Now;
        public DateTime End_Date { get; set; }

        public virtual List<Promotion_Category>? Promotion_Categories { get; set; }

    }
}
