using System;
using System.Collections.Generic;

namespace Coding_Events.Models
{
    public class EventCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Event> EventCollection { get; set; }

        public EventCategory(string Name)
        {
            this.Name = Name;
        }
     
    }
}
