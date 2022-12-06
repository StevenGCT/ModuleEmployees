using System.ComponentModel.DataAnnotations;

namespace ModuleEmployees.Models
{
    public class EmployeeEvent
    {
        [Key]
        public int EmployeeId { get; set; }

        public int EventId { get; set; }
    }
}
