using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HKQTravelling.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [Column("user_id")]
        public long UserId { get; set; }

        [Required]
        [Column("username")]
        [MaxLength(256)]
        public string Username { get; set; }

        [Required]
        [Column("password")]
        [MaxLength(256)]
        public string Password { get; set; }

        [Column("status")]
        public int? Status { get; set; }

        [Column("creation_date")]
        public DateTime? CreationDate { get; set; }

        [Column("update_date")]
        public DateTime? UpdateDate { get; set; }

        [Column("role_id")]
        public int? RoleId { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    }
}
