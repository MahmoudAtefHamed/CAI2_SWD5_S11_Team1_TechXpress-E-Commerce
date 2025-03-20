using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
    public class Order_Status
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
    }
}
