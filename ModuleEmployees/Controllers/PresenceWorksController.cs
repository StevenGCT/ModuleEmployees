using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModuleEmployees.Context;
using ModuleEmployees.Models;

namespace ModuleEmployees.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresenceWorksController : ControllerBase
    {
        private readonly AplicationDBContext _context;

        public PresenceWorksController(AplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/PresenceWorks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PresenceWork>>> GetPresenceWorks()
        {
            return await _context.PresenceWorks.ToListAsync();
        }

        // GET: api/PresenceWorks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PresenceWork>> GetPresenceWork(int id)
        {
            var presenceWork = await _context.PresenceWorks.FindAsync(id);

            if (presenceWork == null)
            {
                return NotFound();
            }

            return presenceWork;
        }

        // PUT: api/PresenceWorks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPresenceWork(int id, PresenceWork presenceWork)
        {
            if (id != presenceWork.Id)
            {
                return BadRequest();
            }

            _context.Entry(presenceWork).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PresenceWorkExists(id))
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

        // POST: api/PresenceWorks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PresenceWork>> PostPresenceWork(PresenceWork presenceWork)
        {
            _context.PresenceWorks.Add(presenceWork);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPresenceWork", new { id = presenceWork.Id }, presenceWork);
        }

        // DELETE: api/PresenceWorks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePresenceWork(int id)
        {
            var presenceWork = await _context.PresenceWorks.FindAsync(id);
            if (presenceWork == null)
            {
                return NotFound();
            }

            _context.PresenceWorks.Remove(presenceWork);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PresenceWorkExists(int id)
        {
            return _context.PresenceWorks.Any(e => e.Id == id);
        }
    }
}
