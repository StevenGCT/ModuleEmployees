namespace ModuleEmployees.Models
{
    public class EmployeeEvent
    {
        public int EmployeeId { get; set; }
        public int EventId { get; set; }
        public virtual DateTime? DateAttendance { get; set; }
        public virtual char Status { get; set; } = '0';
    }
}
