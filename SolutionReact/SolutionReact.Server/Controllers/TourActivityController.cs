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
    public class TourActivityController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TourActivityController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TourActivity
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TourActivity>>> GetTourActivities()
        {
            return await _context.TourActivities.ToListAsync();
        }

        // GET: api/TourActivity/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TourActivity>> GetTourActivity(int id)
        {
            var tourActivity = await _context.TourActivities.FindAsync(id);

            if (tourActivity == null)
            {
                return NotFound();
            }

            return tourActivity;
        }

        // PUT: api/TourActivity/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTourActivity(int id, TourActivity tourActivity)
        {
            if (id != tourActivity.Id)
            {
                return BadRequest();
            }

            _context.Entry(tourActivity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TourActivityExists(id))
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

        // POST: api/TourActivity
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TourActivity>> PostTourActivity(TourActivity tourActivity)
        {
            _context.TourActivities.Add(tourActivity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTourActivity", new { id = tourActivity.Id }, tourActivity);
        }

        // DELETE: api/TourActivity/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTourActivity(int id)
        {
            var tourActivity = await _context.TourActivities.FindAsync(id);
            if (tourActivity == null)
            {
                return NotFound();
            }

            _context.TourActivities.Remove(tourActivity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TourActivityExists(int id)
        {
            return _context.TourActivities.Any(e => e.Id == id);
        }
    }
}
