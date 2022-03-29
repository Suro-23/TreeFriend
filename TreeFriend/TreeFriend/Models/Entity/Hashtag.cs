using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TreeFriend.Models.Entity {
    public class Hashtag {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HashtagId { get; set; }

        [Required]
        public string HashtagName { get; set; }

        [Required]
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
