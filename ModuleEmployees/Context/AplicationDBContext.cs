using Microsoft.EntityFrameworkCore;
using ModuleEmployees.Models;

namespace ModuleEmployees.Context
{
    public class AplicationDBContext :DbContext
    {
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options) : base(options)
        {

        }
        public DbSet<ModuleEmployees.Models.Employee> Employee { get; set; }
        public DbSet<ModuleEmployees.Models.Event> Event { get; set; }
        public DbSet<ModuleEmployees.Models.Presence> Presence { get; set; }
        public DbSet<ModuleEmployees.Models.Schedule> Schedule { get; set; }
    }
}
