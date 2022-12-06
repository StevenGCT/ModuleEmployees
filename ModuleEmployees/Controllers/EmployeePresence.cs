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
    public class EmployeePresence : Controller
    {
        private readonly AplicationDBContext _context;

        public EmployeePresence(AplicationDBContext context)
        {
            _context = context;
        }
        //Busqueda por Id
        [HttpGet]
        public async Task<ActionResult<List<Presence>>> Get(int Id)
        {
            var employees = await _context.Presences
                .Where(c => c.EmployeeId == Id)
                .ToListAsync();

            return employees;
        }
    }
}
