using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolutionReact.Server.Models;

namespace SolutionReact.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingParticipantController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BookingParticipantController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BookingParticipant
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingParticipant>>> GetBookingsParticipant()
        {
            return await _context.BookingsParticipant.ToListAsync();
        }

        // GET: api/BookingParticipant/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookingParticipant>> GetBookingParticipant(int id)
        {
            var bookingParticipant = await _context.BookingsParticipant.FindAsync(id);

            if (bookingParticipant == null)
            {
                return NotFound();
            }

            return bookingParticipant;
        }

        // PUT: api/BookingParticipant/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookingParticipant(int id, BookingParticipant bookingParticipant)
        {
            if (id != bookingParticipant.Id)
            {
                return BadRequest();
            }

            _context.Entry(bookingParticipant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingParticipantExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/BookingParticipant
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookingParticipant>> PostBookingParticipant(BookingParticipant bookingParticipant)
        {
            _context.BookingsParticipant.Add(bookingParticipant);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBookingParticipant", new { id = bookingParticipant.Id }, bookingParticipant);
        }

        // DELETE: api/BookingParticipant/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookingParticipant(int id)
        {
            var bookingParticipant = await _context.BookingsParticipant.FindAsync(id);
            if (bookingParticipant == null)
            {
                return NotFound();
            }

            _context.BookingsParticipant.Remove(bookingParticipant);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookingParticipantExists(int id)
        {
            return _context.BookingsParticipant.Any(e => e.Id == id);
        }
    }
}
