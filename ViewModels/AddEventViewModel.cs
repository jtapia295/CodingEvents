using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Coding_Events.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Coding_Events.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 Characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description Required")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "Description must be between 5 and 500 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter a location")]
        public string EventLocation { get; set; }

        [Required(ErrorMessage = "Please enter your number of attendees")]
        [Range(0, 100000, ErrorMessage = "There is a max of 100,000 attendees.")]
        public int Attendees { get; set; }

        [Compare("IsTrue", ErrorMessage = "Registration is required")]
        public bool RegistrationRequired { get; set; }

        public bool IsTrue { get { return true; } }

        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        [Required(ErrorMessage = "Please enter an Email")]
        public string ContactEmail { get; set; }

        public EventType Type{ get; set; }

        public List<SelectListItem> EventTypes { get; set; } = new List<SelectListItem> 
        { 
            new SelectListItem(EventType.Conference.ToString(), (( int) EventType.Conference).ToString()),
            
            new SelectListItem(EventType.Meetup.ToString(), ((int) EventType.Meetup).ToString()),

            new SelectListItem(EventType.Social.ToString(), ((int) EventType.Social).ToString()),

            new SelectListItem(EventType.Workshop.ToString(), ((int) EventType.Workshop).ToString())
        };






    }
}
