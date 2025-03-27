// Models/Event.cs
using System;
using System.ComponentModel.DataAnnotations;

namespace EventRegistrationApp.Models
{
    public class Event
    {   
        [Required(ErrorMessage = "Event name is required.")]
        [StringLength(100, ErrorMessage = "Event name must be less than 100 characters.")]
        public string ?Name { get; set; }
        [Required(ErrorMessage = "Event date is required.")]
    [DataType(DataType.Date)]
        public DateTime ?Date { get; set; }
        [Required(ErrorMessage = "Location is required.")]
    [StringLength(200, ErrorMessage = "Location must be less than 200 characters.")]
        public string ?Location { get; set; }
    }
}