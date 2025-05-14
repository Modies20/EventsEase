using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventsEase.Models;

namespace EventsEase.Data
{
    public class EventsEaseContext : DbContext
    {
        internal object BookingDetailsView;

        public EventsEaseContext (DbContextOptions<EventsEaseContext> options)
            : base(options)
        {
        }

        public DbSet<EventsEase.Models.Venue> Venue { get; set; } = default!;
        public DbSet<EventsEase.Models.Event> Event { get; set; } = default!;
        public DbSet<EventsEase.Models.Booking> Booking { get; set; } = default!;
    }
}
