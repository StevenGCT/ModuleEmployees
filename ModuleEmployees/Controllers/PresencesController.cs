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
    public class PresencesController : ControllerBase
    {
        private readonly AplicationDBContext _context;

        public PresencesController(AplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/Presences
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Presence>>> GetPresences()
        {
            return await _context.Presences.ToListAsync();
        }

        // GET: api/Presences/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Presence>> GetPresence(int id)
        {
            var presence = await _context.Presences.FindAsync(id);

            if (presence == null)
            {
                return NotFound();
            }

            return presence;
        }

        // PUT: api/Presences/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPresence(int id, Presence presence)
        {
            if (id != presence.PresenceId)
            {
                return BadRequest();
            }

            _context.Entry(presence).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PresenceExists(id))
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

        // POST: api/Presences
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Presence>> PostPresence(Presence presence)
        {
            _context.Presences.Add(presence);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPresence", new { id = presence.PresenceId }, presence);
        }

        // DELETE: api/Presences/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePresence(int id)
        {
            var presence = await _context.Presences.FindAsync(id);
            if (presence == null)
            {
                return NotFound();
            }

            _context.Presences.Remove(presence);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PresenceExists(int id)
        {
            return _context.Presences.Any(e => e.PresenceId == id);
        }
    }
}
