using System.ComponentModel.DataAnnotations;

namespace ModuleEmployees.Models
{
    public class EmployeeEvent
    {
        public int EmployeeId { get; set; }
        public int EventId { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateAttendance { get; set; }
        public char Status { get; set; } = '0';
    }
}
