using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HKQTravelling.Models
{
    [Table("tour_days")]
    public class TourDay
    {
        [Key]
        [Column("tour_day_id")]
        public long TourDayId { get; set; }

        [Column("day_number")]
        public int? DayNumber { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("destination")]
        [MaxLength(100)]
        public string Destination { get; set; }

        [Column("time_schedule")]
        public DateTime? TimeSchedule { get; set; }

        [Column("tour_id")]
        public long? TourId { get; set; }

        [ForeignKey("TourId")]
        public Tour Tour { get; set; }
    }
}
