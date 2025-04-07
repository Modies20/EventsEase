using System.ComponentModel.DataAnnotations;

namespace EventsEase.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public int VenueId { get; set; }
        public int EventId { get; set; }

        // For bookings spanning a time range
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        // Navigation properties
        public Venue Venue { get; set; }
        public Event Event { get; set; }
    }
}
