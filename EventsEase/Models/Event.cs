﻿using System.ComponentModel.DataAnnotations;

namespace EventsEase.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string Description { get; set; }

        public ICollection<Booking> Bookings { get; set; }
        public int EventTypeId { get; set; }
        public EventType EventType { get; set; }
    }
}
