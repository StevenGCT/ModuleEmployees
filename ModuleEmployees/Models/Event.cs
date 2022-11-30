using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModuleEmployees.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required(ErrorMessage = "The AddressEvent is required for Event")]
        [StringLength(120, ErrorMessage = "The {0} must be: minimum {3} and maximum {50}", MinimumLength = 3)]
        public string AddressEvent { get; set; }

        [Required(ErrorMessage = "The DateEvent is required for Event")]
        public DateTime DateEvent { get; set; }

        [Required(ErrorMessage = "The Status is required for Event")]
        public char Status { get; set; }

        [Required(ErrorMessage = "The RegisterDate is required for Event")]
        public DateTime RegisterDate { get; set; }
    }
}
