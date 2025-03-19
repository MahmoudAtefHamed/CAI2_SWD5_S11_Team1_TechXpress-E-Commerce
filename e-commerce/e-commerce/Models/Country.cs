using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string CountryName { get; set; }
    }
}
