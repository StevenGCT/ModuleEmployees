using NuGet.ProjectModel;
using System.ComponentModel.DataAnnotations;

namespace ModuleEmployees.Models
{
    public class Presence
    {
        public int PresenceId { get; set; }
        [Required(ErrorMessage = "The DateAttendance is required")]
        public DateTime DateAttendance { get; set; }
        [Required(ErrorMessage = "The AdmissionTime is required")]
        public TimeSpan AdmissionTime { get; set; }
        [Required(ErrorMessage = "The DepartureTime is required")]
        public TimeSpan DepartureTime { get; set; }
        [Required(ErrorMessage = "The Status is required for Employees")]
        public char Status { get; set; } = '1';

        [Required(ErrorMessage = "The RegisterDate is required")]
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
