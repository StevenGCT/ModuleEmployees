using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModuleEmployees.Models
{
    public class Employee 
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "The Name is required for Employees")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The LastName is required for Employees")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The SecondLastName is required for Employees")]
        public string SecondLastName { get; set; }

        [Required(ErrorMessage = "The Phone is required for Employees")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "The Address is required for Employees")]
        public string Address { get; set; }

        [Required(ErrorMessage = "The Type is required for Employees")]
        public string Type { get; set; }

        [Required(ErrorMessage = "The Ci is required for Employees")]
        public string Ci { get; set; }

        [Required(ErrorMessage = "The Birthday is required")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "The Phote is required for Employees")]
        public string Photo { get; set; }

        [Required(ErrorMessage = "The Status is required for Employees")]
        public char Status { get; set; } = '1';

        [Required(ErrorMessage = "The RegisterDate is required")]
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        //----

        public List<Event>? Events  { get; set; }
        public Schedule? Schedule { get; set; }
        public List<Presence> Presences { get; set; }
    }
}
