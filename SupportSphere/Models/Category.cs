using System.ComponentModel.DataAnnotations;

namespace SupportSphere.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }

        public ICollection<SubCategory>? SubCategories { get; set; }
    }
}