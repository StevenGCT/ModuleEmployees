using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModuleEmployees.Context;
using ModuleEmployees.Models;

namespace ModuleEmployees.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsiggnedEventController : ControllerBase
    {
        private readonly AplicationDBContext _context;

        public AsiggnedEventController(AplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet("{NameEvent}")]
        public async Task<ActionResult<List<Event>>> Get(string NameEvent)
        {
            var events = await _context.Events
                .Where(c => c.NameEvent == NameEvent)
                .Include(e => e.Employees)
                .ToListAsync();

            return events;
        }
    }
}
