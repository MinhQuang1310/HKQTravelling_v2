using HKQTravelling.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HKQTravelling.Models
{
    [Table("ticket_information")]
    public class TicketInformation
    {
        [Key]
        [Column("ticket_info_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long TicketInfoId { get; set; }


        [Column("ticket_type_id")]
        public int? TicketTypeId { get; set; }

        [Column("user_id")]
        public long? UserId { get; set; }

        [Column("adults_number")]
        public int Adults_Number { get; set; }

        [Column("kid_number")]
        public int Kid_Number { get; set; }

        [Column("kid_age")]
        public int Kid_Age { get; set; }


        [ForeignKey("TicketTypeId")]
        public TicketType TicketType { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
