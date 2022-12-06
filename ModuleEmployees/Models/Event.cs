using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModuleEmployees.Models
{
    public class Event
    {
        public int EventId { get; set; }

        [Required(ErrorMessage = "The AddressEvent is required for Employees")]
        [StringLength(120, ErrorMessage = "Please enter a value between 5 and 120 characters", MinimumLength = 5)]
        public string AddressEvent { get; set; }

        [Required(ErrorMessage = "The nameEvent is required for Employees")]
        [StringLength(80, ErrorMessage = "Please enter a value between 4 and 80 characters", MinimumLength = 4)]
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
        [JsonIgnore]
        public List<Employee>? Employees { get; set; } //Para hacer realacion con la otra tabla (ICollection = 1 a muchos)
    }
}
