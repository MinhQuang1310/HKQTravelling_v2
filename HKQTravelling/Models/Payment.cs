using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HKQTravelling.Models
{
    [Table("payments")]
    public class Payment
    {
        [Key]
        [Column("payment_id")]
        public long PaymentId { get; set; }

        [Column("quantity")]
        public int? Quantity { get; set; }

        [Column("payment_date")]
        public DateTime? PaymentDate { get; set; }

        [Column("booking_id")]
        public long? BookingId { get; set; }

        [ForeignKey("BookingId")]
        public Booking Booking { get; set; }
    }
}
