using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModuleEmployees.Models
{
    public class Employee 
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "The Name is required for Employees")]
        [StringLength(50, ErrorMessage = "The {0} must be: minimum {3} and maximum {50}", MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The LastName is required for Employees")]
        [StringLength(50, ErrorMessage = "The {0} must be: minimum {3} and maximum {50}", MinimumLength = 3)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The SecondLastName is required for Employees")]
        [StringLength(50, ErrorMessage = "The {0} must be: minimum {3} and maximum {50}", MinimumLength = 3)]
        public string SecondLastName { get; set; }

        [Required(ErrorMessage = "The Phone is required for Employees")]
        [StringLength(8, ErrorMessage = "The {0} must be: minimum {8} and maximum {8}", MinimumLength = 8)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "The Phone is required for Employees")]
        [StringLength(50, ErrorMessage = "The {0} must be: minimum {8} and maximum {3}", MinimumLength = 3)]
        public string Address { get; set; }

        [Required(ErrorMessage = "The Phone is required for Employees")]
        [StringLength(10, ErrorMessage = "The {0} must be: minimum {8} and maximum {10}", MinimumLength = 8)]
        public string Type { get; set; }

        [Required(ErrorMessage = "The Phone is required for Employees")]
        [StringLength(7, ErrorMessage = "The {0} must be: minimum {7} and maximum {8}", MinimumLength = 8)]
        public string Ci { get; set; }  

        [Required(ErrorMessage = "The Birthday is required")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "The Phone is required for Employees")]
        public char Status { get; set; }

        [Required(ErrorMessage = "The RegisterDate is required")]
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }

        public int EventId { get; set; }

        public Event? Event { get; set; }
    }
}
