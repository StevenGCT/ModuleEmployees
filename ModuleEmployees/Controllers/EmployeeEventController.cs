using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModuleEmployees.Context;
using ModuleEmployees.Models;

namespace ModuleEmployees.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeEventController : ControllerBase
    {
        private readonly AplicationDBContext _context;

        public EmployeeEventController(AplicationDBContext context)
        {
            _context = context;
        }
        //Busqueda por Id
        [HttpGet]
        public async Task<ActionResult<List<Employee>>> Get(int Id)
        {
            var employees = await _context.Employees
                .Where(c => c.EmployeeId == Id)
                .Include(c => c.Events)
                .ToListAsync();

            return employees;
        }

    }
}
