using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModuleEmployees.Context;
using ModuleEmployees.Models;

namespace ModuleEmployees.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckPresenceController : ControllerBase
    {
        private readonly AplicationDBContext _context;

        public CheckPresenceController(AplicationDBContext context)
        {
            _context = context;
        }

    }
}
