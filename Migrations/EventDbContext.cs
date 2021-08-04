﻿using System;
using Microsoft.EntityFrameworkCore;
using Coding_Events.Models;

namespace Coding_Events.Data
{
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCategory> Categories { get; set; }

        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options)
        {
        }
    }
}
