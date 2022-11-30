using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModuleEmployees.Models
{
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }

        [Required(ErrorMessage = "The Day is required for Employees")]
        [StringLength(11, ErrorMessage = "The {0} must be: minimum {3} and maximum {50}", MinimumLength = 5)]
        public string Day { get; set; }

        [Required(ErrorMessage = "The EmployeeId is required for Employees")]
        public TimeOnly StartTime { get; set; }

        [Required(ErrorMessage = "The EndTime is required for Employees")]
        public TimeOnly EndTime { get; set; }

        [Required(ErrorMessage = "The Status is required for Employees")]
        public char Status { get; set; }

        [Required(ErrorMessage = "The RegisterDate is required")]
        public DateTime RegisterDate { get; set; }

    }
}
