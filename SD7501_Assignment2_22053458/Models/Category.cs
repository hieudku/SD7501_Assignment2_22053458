using System.ComponentModel.DataAnnotations;

namespace SD7501_Assignment2_22053458.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
