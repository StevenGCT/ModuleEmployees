using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModuleEmployees.Models
{
    public class Event
    {
        public int EventId { get; set; }

        [Required(ErrorMessage = "The AddressEvent is required for Employees")]
        public string AddressEvent { get; set; }

        [Required(ErrorMessage = "The nameEvent is required for Employees")]
        [Range(4, 50, ErrorMessage = "Please enter a value between 4 and 50 characters")]
        [DataType(DataType.Text)]
        public string NameEvent { get; set; }

        [Required(ErrorMessage = "The DateEvent is required")]
        [DataType(DataType.Date)]
        public DateTime DateEvent { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "The Status is required for Employees")]
        public char Status { get; set; } = '1';

        [Required(ErrorMessage = "The RegisterDate is required")]
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        //---
        public List<Employee>? Employees { get; set; } //Para hacer realacion con la otra tabla (ICollection = 1 a muchos)
    }
}
