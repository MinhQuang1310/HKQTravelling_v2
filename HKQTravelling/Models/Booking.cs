using HKQTravelling.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HKQTravelling.Models
{
    [Table("bookings")]
    public class Booking
    {
        [Key]
        [Column("booking_id")]
        public long BookingId { get; set; }

        [Column("booking_date")]
        public DateTime? BookingDate { get; set; }

        [Column("ticket_info_id")]
        public long? TicketInfoId { get; set; }

        [Column("tour_id")]
        public long? TourId { get; set; }

        [Column("user_id")]
        public long? UserId { get; set; }

        [ForeignKey("TicketInfoId")]
        public TicketInformation TicketInformation { get; set; }

        [ForeignKey("TourId")]
        public Tour Tour { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
