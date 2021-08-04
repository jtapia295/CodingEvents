using System;
using System.Collections.Generic;
using Coding_Events.Models;

namespace Coding_Events.Data
{
    public class EventData
    {
        private static Dictionary<int, Event> Events = new Dictionary<int, Event> { };


        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }
        public static Event GetById(int Id)
        {
            return Events[Id];
        }
        public static void Remove(int Id)
        {
            Events.Remove(Id);
        }

        public static void Update(int Id, string name, string description)
        {
            Events[Id].Name = name;
            Events[Id].Description = description;
        }
        public EventData()
        {

        }
    }
}
