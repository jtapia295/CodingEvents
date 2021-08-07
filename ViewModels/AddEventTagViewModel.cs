using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Coding_Events.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Coding_Events.ViewModels
{
    public class AddEventTagViewModel
    {
        [Required(ErrorMessage = "Event is Required")]
        public int EventId { get; set; }
        public Event Event { get; set; }


        [Required(ErrorMessage = "Tag is Required")]
        public int TagId { get; set; }
        public List<SelectListItem> Tags { get; set; }

        public AddEventTagViewModel(Event theEvent, List<Tag> Tags)
        {
            this.Tags = new List<SelectListItem>();
            foreach (var tag in Tags)
            {
                this.Tags.Add(new SelectListItem { Value = tag.Id.ToString(), Text = tag.Name });
            }
            Event = theEvent;
        }

        public AddEventTagViewModel()
        {

        }
    }
}







