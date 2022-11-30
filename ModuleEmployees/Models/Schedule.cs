using System.ComponentModel.DataAnnotations;

namespace ModuleEmployees.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        [Required(ErrorMessage = "The Day is required")]
        public string NameDay { get; set; }
        [Required(ErrorMessage = "The StartTime is required")]
        public TimeSpan StartTime { get; set; }
        [Required(ErrorMessage = "The FinalTime is required")]
        public TimeSpan FinalTime { get; set; }
        [Required(ErrorMessage = "The Status is required for Employees")]
        public char Status { get; set; } = '1';

        [Required(ErrorMessage = "The RegisterDate is required")]
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; } = DateTime.Now;

        //---
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
