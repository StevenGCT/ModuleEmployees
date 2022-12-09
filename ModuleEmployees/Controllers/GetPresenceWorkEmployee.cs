using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModuleEmployees.Context;
using ModuleEmployees.Models;

namespace ModuleEmployees.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetPresenceWorkEmployee : ControllerBase
    {
        private readonly AplicationDBContext _context;

        public GetPresenceWorkEmployee(AplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetPresenceWork(int id)
        {
            var presenceWork = await _context.Employees
                                .Include(e => e.PresenceWorks)
                                .FirstOrDefaultAsync(e => e.EmployeeId == id);

            if (presenceWork == null)
            {
                return NotFound();
            }

            return presenceWork;
        }
    }
}
