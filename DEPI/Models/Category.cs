using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "Invalid Category Name")]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "from 1 to 100")]
        [DisplayName("Category Display Order")]
        public int DisplayOrder { get; set; }

    }
}
