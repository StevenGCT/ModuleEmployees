using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModuleEmployees.Models
{
    public class Presence
    {
        [Key]
        public int PresenceId { get; set; }

        [Required(ErrorMessage = "The EmployeeId is required for Employees")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "The EventId is required for Employees")]
        public int EventId { get; set; }

        [Required(ErrorMessage = "The Status is required for Employees")]
        public char Status { get; set; }
    }
}
