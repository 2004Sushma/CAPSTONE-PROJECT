using SupportSphere.Models;
using Xunit;

namespace SupportSphere.Tests
{
    public class TicketTests
    {
        [Fact]
        public void Default_Status_Should_Be_Open()
        {
            var ticket = new Ticket();

            Assert.Equal("Open", ticket.Status);
        }

        [Fact]
        public void Default_Priority_Should_Be_Medium()
        {
            var ticket = new Ticket();

            Assert.Equal("Medium", ticket.Priority);
        }

        [Fact]
        public void Ticket_Title_Should_Be_Assigned()
        {
            var ticket = new Ticket
            {
                Title = "Password Reset Request"
            };

            Assert.Equal("Password Reset Request", ticket.Title);
        }

        [Fact]
        public void TicketNumber_Should_Start_With_TKT()
        {
            var ticket = new Ticket
            {
                TicketNumber = "TKT123456"
            };

            Assert.StartsWith("TKT", ticket.TicketNumber);
        }

        [Fact]
        public void CreatedDate_Should_Be_Assigned()
        {
            var ticket = new Ticket();

            Assert.NotEqual(default(DateTime), ticket.CreatedDate);
        }
    }
}