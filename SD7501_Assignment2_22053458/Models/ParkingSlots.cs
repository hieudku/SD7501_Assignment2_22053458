using System.ComponentModel.DataAnnotations;

namespace SD7501_Assignment2_22053458.Models
{
    public class ParkingSlots
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? SlotCode { get; set; } // slot code
        public string? Location { get; set; } // street
        public bool IsVacant { get; set; }

        public ICollection<Bookings> Bookings { get; set; } = new List<Bookings>();
    }
}
