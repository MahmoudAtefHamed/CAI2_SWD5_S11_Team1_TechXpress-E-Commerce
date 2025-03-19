using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public int Unit_Number { get; set; }
        public int Street_Number { get; set; }
        public string Address_Line1 { get; set; }
        public string Address_Line2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Postal_Code { get; set; }
        [ForeignKey("Country")]
        public int Country_Id { get; set; }

        public virtual Country? Country { get; set; }

    
    
    }
}
