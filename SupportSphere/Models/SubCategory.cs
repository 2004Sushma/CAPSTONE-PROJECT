using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupportSphere.Models
{
    public class SubCategory
    {
        public int SubCategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string SubCategoryName { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}