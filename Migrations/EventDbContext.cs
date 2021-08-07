using System;
using Microsoft.EntityFrameworkCore;
using Coding_Events.Models;

namespace Coding_Events.Data
{
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCategory> Categories { get; set; }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<EventTag> EventTags { get; set; }

       protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventTag>().HasKey(et => new { et.EventId, et.TagId });
        }
        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options)
        {
        }
    }
}
