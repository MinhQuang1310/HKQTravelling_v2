using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using HKQTravelling.Models;

namespace HKQTravelling.Models
{
    [Table("feedbacks")]
    public class Feedback
    {
        [Key]
        [Column("feedback_id")]
        public long FeedbackId { get; set; }

        [Column("like")]
        public long? Like { get; set; }

        [Column("comment")]
        [MaxLength(1000)]
        public string Comment { get; set; }

        [Column("user_id")] 
        public long UserId { get; set; }
        public User User { get; set; }

        [Column("tour_id")]
        public long TourId { get; set; }
        public Tour Tour { get; set; }
    }
}
