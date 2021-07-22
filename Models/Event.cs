﻿using System;
namespace Coding_Events.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; } 

        public int Id { get;}
        private static int nextId = 1;

        public Event()
        {
            Id = nextId;
            nextId++;
        }


        public Event(string name, string description) : this()
        {
            Name = name;
            Description = description;
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