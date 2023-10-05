using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HKQTravelling.Models
{
    [Table("ticket_types")]
    public class TicketType
    {
        [Key]
        [Column("ticket_type_id")]
        public int TicketTypeId { get; set; }

        [Required]
        [Column("type_name")]
        [MaxLength(100)]
        public string TypeName { get; set; }
    }
}
