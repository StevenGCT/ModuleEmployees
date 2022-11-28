using Microsoft.EntityFrameworkCore;
using ModuleEmployees.Models;

namespace ModuleEmployees.Context
{
    public class AplicationDBContext :DbContext
    {
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Event> Events { get; set; }
    }
}
