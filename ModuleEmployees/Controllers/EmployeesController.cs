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
    public class EmployeesController : ControllerBase
    {
        private readonly AplicationDBContext _context;

        public EmployeesController(AplicationDBContext context)
        {
            _context = context;
        }
        //Busqueda por Id
        [HttpGet]
        public async Task<ActionResult<List<Employee>>> Get(int Id)
        {
            var employees = await _context.Employees
                .Where(c => c.EmployeeId == Id)
                .ToListAsync();

            return employees;
        }

        [HttpGet("{TypeEmployee}")]
        public async Task<ActionResult<List<Employee>>> Get(string TypeEmployee)
        {
            var employees = await _context.Employees
                .Where(c => c.Type == TypeEmployee)
                .ToListAsync();

            return employees;
        }

        [HttpPost]
        public async Task<ActionResult<List<Employee>>> Create(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return await Get(employee.EmployeeId);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }
    }
}
