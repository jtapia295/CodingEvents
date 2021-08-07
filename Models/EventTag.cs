using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coding_Events.Models
{
    public class EventTag
    {
        public Tag Tag { get; set; }
        public int TagId { get; set; }
        
        public Event Event { get; set; }
        public int EventId { get; set; }

        public EventTag()
        {

        }
    }
}


