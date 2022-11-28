using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModuleEmployees.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required(ErrorMessage = "The AddressEvent is required for Employees")]
        [StringLength(50, ErrorMessage = "The {0} must be: minimum {3} and maximum {50}", MinimumLength = 3)]
        public string AddressEvent { get; set; }

        [Required(ErrorMessage = "The DateEvent is required")]
        [DataType(DataType.Date)]
        public DateTime DateEvent { get; set; }

        public ICollection<Employee>? Employees { get; set; } //Para hacer realacion con la otra tabla (ICollection = 1 a muchos)
    }
}
