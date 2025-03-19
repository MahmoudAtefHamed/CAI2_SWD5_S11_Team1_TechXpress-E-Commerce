using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
    public class Payment_Type
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
