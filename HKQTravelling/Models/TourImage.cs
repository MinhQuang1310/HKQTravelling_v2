using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HKQTravelling.Models
{
    [Table("tour_images")]
    public class TourImage
    {
        [Key]
        [Column("image_id")]
        public long ImageId { get; set; }

        [Column("image_url")]
        public string ImageUrl { get; set; }

        [Column("tour_id")]
        public long? TourId { get; set; }

        [ForeignKey("TourId")]
        public Tour Tour { get; set; }
    }
}
