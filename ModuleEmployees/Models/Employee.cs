using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModuleEmployees.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "The Name is required for Employee")]
        [StringLength(50, ErrorMessage = "The {0} must be: minimum {3} and maximum {50}", MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The LastName is required for Employee")]
        [StringLength(50, ErrorMessage = "The {0} must be: minimum {3} and maximum {50}", MinimumLength = 3)]
        public string LastName { get; set; }

        [StringLength(50, ErrorMessage = "The {0} must be: minimum {3} and maximum {50}", MinimumLength = 3)]
        public string SecondLastName { get; set; }

        [Required(ErrorMessage = "The Phone is required for Employee")]
        [StringLength(8, ErrorMessage = "The {0} must be: minimum {8} and maximum {8}", MinimumLength = 8)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "The Address is required for Employee")]
        [StringLength(120, ErrorMessage = "The {0} must be: minimum {8} and maximum {120}", MinimumLength = 3)]
        public string Address { get; set; }

        [Required(ErrorMessage = "The Type is required for Employee")]
        [StringLength(11, ErrorMessage = "The {0} must be: minimum {8} and maximum {10}", MinimumLength = 7)]
        public string Type { get; set; }

        [Required(ErrorMessage = "The Photo is required for Employee")]
        public string Photo { get; set; }

        [Required(ErrorMessage = "The Ci is required for Employee")]
        [StringLength(7, ErrorMessage = "The {0} must be: minimum {7} and maximum {8}", MinimumLength = 8)]
        public string Ci { get; set; }

        [Required(ErrorMessage = "The Birthday is required for Employee")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "The Status is required for Employee")]
        public char Status { get; set; }

        [Required(ErrorMessage = "The RegisterDate is required for Employee")]
        public DateTime RegisterDate { get; set; }


    }
}
