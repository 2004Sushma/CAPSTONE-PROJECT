using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupportSphere.Data;
using SupportSphere.Models;

namespace SupportSphere.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TicketsApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TicketsApi
        [HttpGet]
        public async Task<IActionResult> GetTickets()
        {
            var tickets = await _context.Tickets.ToListAsync();
            return Ok(tickets);
        }

        // GET: api/TicketsApi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTicket(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);

            if (ticket == null)
                return NotFound();

            return Ok(ticket);
        }

        // POST: api/TicketsApi
        [HttpPost]
        public async Task<IActionResult> PostTicket(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetTicket),
                new { id = ticket.TicketId },
                ticket);
        }

        // PUT: api/TicketsApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTicket(int id, Ticket ticket)
        {
            if (id != ticket.TicketId)
                return BadRequest();

            _context.Entry(ticket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await TicketExists(id))
                    return NotFound();

                throw;
            }

            return NoContent();
        }

        // DELETE: api/TicketsApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);

            if (ticket == null)
                return NotFound();

            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private async Task<bool> TicketExists(int id)
        {
            return await _context.Tickets.AnyAsync(e => e.TicketId == id);
        }
    }
}