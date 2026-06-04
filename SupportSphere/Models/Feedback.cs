using System.ComponentModel.DataAnnotations;

namespace SupportSphere.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public string? Comments { get; set; }

        public int TicketId { get; set; }

        public Ticket? Ticket { get; set; }
    }
}