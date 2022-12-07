using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModuleEmployees.Context;
using ModuleEmployees.Models;

namespace ModuleEmployees.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeEmployeeController : ControllerBase
    {
        private readonly AplicationDBContext _context;

        public TypeEmployeeController(AplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet("{TypeEmployee}")]
        public async Task<ActionResult<List<Employee>>> Get(string TypeEmployee)
        {
            var employees = await _context.Employees
                .Where(c => c.Type == TypeEmployee)
                .ToListAsync();

            return employees;
        }
    }
}
