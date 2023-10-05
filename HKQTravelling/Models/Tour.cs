using HKQTravelling.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HKQTravelling.Models
{
    [Table("tours")]
    public class Tour
    {
        [Key]
        [Column("tour_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long TourId { get; set; }

        [Column("tour_name")]
        [MaxLength(200)]
        public string TourName { get; set; }

        [Column("start_location")]
        [MaxLength(100)]
        public string StartLocation { get; set; }

        [Column("end_location")]
        [MaxLength(100)]
        public string EndLocation { get; set; }

        [Column("price")]
        public int? Price { get; set; }

        [Column("start_date")]
        public DateTime? StartDate { get; set; }

        [Column("end_date")]
        public DateTime? EndDate { get; set; }

        [Column("status")]
        public int? Status { get; set; }

        [Column("creation_date")]
        public DateTime? CreationDate { get; set; }

        [Column("update_date")]
        public DateTime? UpdateDate { get; set; }

        [Column("remaining")]
        public int? Remaining { get; set; }

        [Column("dis_id")]
        public long Discount_Id { get; set; }


        [ForeignKey("Discount_Id")]
        public Discount Discount { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    }
}
