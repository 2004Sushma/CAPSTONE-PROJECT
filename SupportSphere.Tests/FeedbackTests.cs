using SupportSphere.Models;
using Xunit;

namespace SupportSphere.Tests
{
    public class FeedbackTests
    {
        [Fact]
        public void Rating_Should_Be_Assigned_Correctly()
        {
            var feedback = new Feedback
            {
                Rating = 5
            };

            Assert.Equal(5, feedback.Rating);
        }

        [Fact]
        public void Rating_Should_Allow_Minimum_Value()
        {
            var feedback = new Feedback
            {
                Rating = 1
            };

            Assert.Equal(1, feedback.Rating);
        }

        [Fact]
        public void Comments_Should_Be_Assigned()
        {
            var feedback = new Feedback
            {
                Comments = "Excellent Support"
            };

            Assert.Equal("Excellent Support", feedback.Comments);
        }

        [Fact]
        public void TicketId_Should_Be_Assigned()
        {
            var feedback = new Feedback
            {
                TicketId = 10
            };

            Assert.Equal(10, feedback.TicketId);
        }

        [Fact]
        public void Feedback_Object_Should_Not_Be_Null()
        {
            var feedback = new Feedback();

            Assert.NotNull(feedback);
        }
    }
}