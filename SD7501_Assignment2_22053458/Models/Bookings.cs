using System.ComponentModel.DataAnnotations;
namespace SD7501_Assignment2_22053458.Models
{
    public class Bookings
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; } // User ID of the person who booked the slot
        public int ParkingSlotId { get; set; }
        public ParkingSlots ParkingSlot { get; set; }

        public DateTime BookingDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

    }
}
