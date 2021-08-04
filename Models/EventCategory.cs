using System;
namespace Coding_Events.Models
{
    public class EventCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }



        public EventCategory(string Name)
        {
            this.Name = Name;
        }
    }
}
