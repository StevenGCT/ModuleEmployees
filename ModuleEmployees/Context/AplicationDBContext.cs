using Microsoft.EntityFrameworkCore;
using ModuleEmployees.Models;

namespace ModuleEmployees.Context
{
    public class AplicationDBContext :DbContext
    {
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options) : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Presence>()
        //         .HasOne(e => e.Employee)
        //         .WithMany(p => p.Presences)
        //         .HasForeignKey(ei => ei.EmployeeId);            
            
        //    modelBuilder.Entity<Presence>()
        //         .HasOne(e => e.Event)
        //         .WithMany(p => p.Presences)
        //         .HasForeignKey(ei => ei.EventId);
        //}

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Event> Events { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
    }
}
