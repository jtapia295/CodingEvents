using System;
using System.Collections.Generic;

namespace Coding_Events.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string ContactEmail { get; set; }

        public string EventLocation { get; set; }

        public int Attendees { get; set; }

        public bool RegistrationRequired { get; set; }

        public int Id { get; set; }

        public EventCategory Category { get; set; }
        public int  CategoryId { get; set; }



        public Event()
        {
         
        }

        public override bool Equals(object obj)
        {
            return obj is Event @event && Id == @event.Id;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Name;
        }


    }
}
