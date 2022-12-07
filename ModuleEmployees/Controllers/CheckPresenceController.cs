using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModuleEmployees.Context;

namespace ModuleEmployees.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckPresenceController : ControllerBase
    {
        private readonly AplicationDBContext _context;

        public v(AplicationDBContext context)
        {
            _context = context;
        }

        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutEmployee(int id, Employee employee)
        //{
        //    if (id != employee.EmployeeId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(employee).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!EmployeeExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}
    }
}
