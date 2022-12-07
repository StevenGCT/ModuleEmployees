using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ModuleEmployees.Models
{
    public class Employee 
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "The Name is required for Employees")]
        [StringLength(15, ErrorMessage = "Please enter a value between 4 and 15 characters", MinimumLength = 4)]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The LastName is required for Employees")]
        [StringLength(15, ErrorMessage = "Please enter a value between 4 and 15 characters", MinimumLength = 4)]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The SecondLastName is required for Employees")]
        [StringLength(15, ErrorMessage = "Please enter a value between 4 and 15 characters", MinimumLength = 4)]
        [DataType(DataType.Text)]
        public string SecondLastName { get; set; }

        [Required(ErrorMessage = "The Phone is required for Employees")]
        [StringLength(13, ErrorMessage = "Please enter a value between 8 and 15 characters", MinimumLength =8)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "The Address is required for Employees")]
        [StringLength(120, ErrorMessage = "Please enter a value between 8 and 120 characters", MinimumLength = 8)]
        [DataType(DataType.Text)]
        public string Address { get; set; }

        [Required(ErrorMessage = "The Type is required for Employees")]
        public string Type { get; set; }

        [Required(ErrorMessage = "The Ci is required for Employees")]
        [StringLength(10, ErrorMessage = "Please enter a value between 7 and 10 characters", MinimumLength = 7)]
        [DataType(DataType.Text)]
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
        [System.Text.Json.Serialization.JsonIgnore]
        public List<Event>? Events  { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public List<Schedule>? Schedules { get; set; }
    }
}
