using System;
using System.Collections.Generic;
using Coding_Events.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Coding_Events.ViewModels
{
    public class TagDetailViewModel
    {
        public int TagId { get; set; }
        public string Name { get; set; }

        public List<SelectListItem> Events { get; set; }

        public TagDetailViewModel(Tag theTag, List<EventTag> eventTags)
        {
            TagId = theTag.Id;
            Name = theTag.Name;

            Events = new List<SelectListItem>();
            if (eventTags.Count == 0)
            {
                Events.Add(new SelectListItem { Value = "Empty", Text = "No Events using current Tag" });
            }
            else
            {
                foreach (var Event in eventTags)
                {
                    Events.Add(new SelectListItem { Value = Event.EventId.ToString(), Text = Event.Event.Name });
                }
            }


        }
    }
}
