using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HKQTravelling.Models
{
    [Table("user_details")]
    public class UserDetails
    {
        [Key]
        [Column("user_id")]
        [ForeignKey("User")]
        public long UserId { get; set; }

        [Column("full_name")]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [Column("email")]
        [MaxLength(256)]
        public string Email { get; set; }

        [Required]
        [Column("phone_number")]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [Column("birthdate")]
        public DateTime? Birthdate { get; set; }

        [Column("NI_number")]
        public string NI_number { get; set; }

        [Column("gender")]
        public string Gender { get; set; }
        [Column("age")]
        public int Age { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
