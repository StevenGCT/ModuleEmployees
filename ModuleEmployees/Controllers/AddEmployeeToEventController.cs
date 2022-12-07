using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModuleEmployees.Context;
using ModuleEmployees.Models;

namespace ModuleEmployees.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddEmployeeToEventController : ControllerBase
    {
        private readonly AplicationDBContext _context;

        public AddEmployeeToEventController(AplicationDBContext context)
        {
            _context = context;
        }

        [HttpPost("addEmployeesToEvent")]
        public async Task<ActionResult<Event>> AddEmployeeEvent(EmployeeEvent employeeEvent)

        {
            var evento = await _context.Events
                .Where(c => c.EventId == employeeEvent.EventId)
                .Include(c => c.Employees)
                .FirstOrDefaultAsync();
            if (evento == null)
                return NotFound();
            var employee = await _context.Employees.FindAsync(employeeEvent.EmployeeId);
            if (employee == null)
                return NotFound();

            evento.Employees.Add(employee);
        
            await _context.SaveChangesAsync();

            return evento;
        }

        [HttpPut("PutStatusEmplyeeEvent")]
        public async Task<IActionResult> PutStatusEmplyeeEvent(int idEmployee, EmployeeEvent employeeEvent)
        {
            if (idEmployee != employeeEvent.EmployeeId)
            {
                return BadRequest();
            }

            _context.Entry(employeeEvent).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
