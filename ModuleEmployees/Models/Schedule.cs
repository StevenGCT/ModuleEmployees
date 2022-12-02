﻿using System.ComponentModel.DataAnnotations;

namespace ModuleEmployees.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }

        [Required(ErrorMessage = "The Name Day is required")]
        [Range(5, 10, ErrorMessage = "Please enter a value between 5 and 10 characters")]
        [DataType(DataType.Text)]
        public string NameDay { get; set; }

        [Required(ErrorMessage = "The StartTime is required")]
        [DataType(DataType.Time)]
        public TimeSpan StartTime { get; set; }

        [Required(ErrorMessage = "The FinalTime is required")]
        [DataType(DataType.Time)]
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
