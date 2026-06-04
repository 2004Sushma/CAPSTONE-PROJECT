using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupportSphere.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }

        public string? TicketNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public string? Description { get; set; }

        public string Status { get; set; } = "Open";

        public string Priority { get; set; } = "Medium";

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? ResolvedDate { get; set; }

        public int CategoryId { get; set; }

        public int SubCategoryId { get; set; }

        public string? CustomerId { get; set; }

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

        [ForeignKey("SubCategoryId")]
        public SubCategory? SubCategory { get; set; }
    }
}