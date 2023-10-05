using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HKQTravelling.Models
{
    [Table("discount")]
    public class Discount
    {
        [Key]
        [Column("dis_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Discount_Id { get; set; }

        [Column("dis_per")]
        public float Discount_percent { get; set; }

        [Column("dis_name")]
        [MaxLength(1000)]
        public string Discount_Name { get; set; }

        [Column("dis_dateStart")]
        public DateTime CreationDateStart { get; set; }

        [Column("dis_dateEnd")]
        public DateTime CreationDateEnd { get; set; }


        [Column("status")]
        public int? Status { get; set; }

        
    }
}
