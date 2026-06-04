using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SupportSphere.Data;
using SupportSphere.Models;

namespace SupportSphere.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public async Task<IActionResult> AllTickets()
        {
            var tickets = await _context.Tickets
                .Include(t => t.Category)
                .Include(t => t.SubCategory)
                .ToListAsync();

            return View(tickets);
        }

        public async Task<IActionResult> ResolveTickets()
        {
            var tickets = await _context.Tickets
                .Include(t => t.Category)
                .Include(t => t.SubCategory)
                .Where(t => t.Status == "Open")
                .ToListAsync();

            return View(tickets);
        }

        public IActionResult Reports()
        {
            ViewBag.TotalTickets = _context.Tickets.Count();
            ViewBag.OpenTickets = _context.Tickets.Count(t => t.Status == "Open");
            ViewBag.ClosedTickets = _context.Tickets.Count(t => t.Status == "Close");

            return View();
        }

        // DETAILS
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var ticket = await _context.Tickets
                .Include(t => t.Category)
                .Include(t => t.SubCategory)
                .FirstOrDefaultAsync(m => m.TicketId == id);

            if (ticket == null)
                return NotFound();

            return View(ticket);
        }

        // EDIT GET
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var ticket = await _context.Tickets.FindAsync(id);

            if (ticket == null)
                return NotFound();

            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", ticket.CategoryId);
            ViewData["SubCategoryId"] = new SelectList(_context.SubCategories, "SubCategoryId", "SubCategoryName", ticket.SubCategoryId);

            return View(ticket);
        }

        // EDIT POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Ticket ticket)
        {
            if (id != ticket.TicketId)
                return NotFound();

            try
            {
                _context.Update(ticket);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(AllTickets));
            }
            catch
            {
                ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", ticket.CategoryId);
                ViewData["SubCategoryId"] = new SelectList(_context.SubCategories, "SubCategoryId", "SubCategoryName", ticket.SubCategoryId);

                return View(ticket);
            }
        }

        // DELETE GET
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var ticket = await _context.Tickets
                .Include(t => t.Category)
                .Include(t => t.SubCategory)
                .FirstOrDefaultAsync(m => m.TicketId == id);

            if (ticket == null)
                return NotFound();

            return View(ticket);
        }

        // DELETE POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);

            if (ticket != null)
            {
                _context.Tickets.Remove(ticket);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(AllTickets));
        }
    }
}