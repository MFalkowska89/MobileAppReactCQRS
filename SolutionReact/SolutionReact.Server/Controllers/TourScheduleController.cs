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
    public class TourScheduleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TourScheduleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TourSchedule
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TourSchedule>>> GetToursSchedule()
        {
            return await _context.ToursSchedule.ToListAsync();
        }

        // GET: api/TourSchedule/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TourSchedule>> GetTourSchedule(int id)
        {
            var tourSchedule = await _context.ToursSchedule.FindAsync(id);

            if (tourSchedule == null)
            {
                return NotFound();
            }

            return tourSchedule;
        }

        // PUT: api/TourSchedule/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTourSchedule(int id, TourSchedule tourSchedule)
        {
            if (id != tourSchedule.Id)
            {
                return BadRequest();
            }

            _context.Entry(tourSchedule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TourScheduleExists(id))
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

        // POST: api/TourSchedule
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TourSchedule>> PostTourSchedule(TourSchedule tourSchedule)
        {
            _context.ToursSchedule.Add(tourSchedule);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTourSchedule", new { id = tourSchedule.Id }, tourSchedule);
        }

        // DELETE: api/TourSchedule/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTourSchedule(int id)
        {
            var tourSchedule = await _context.ToursSchedule.FindAsync(id);
            if (tourSchedule == null)
            {
                return NotFound();
            }

            _context.ToursSchedule.Remove(tourSchedule);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TourScheduleExists(int id)
        {
            return _context.ToursSchedule.Any(e => e.Id == id);
        }
    }
}
