using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TreeFriend.Models.Entity {
    public class Category {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }

        /// <summary>
        /// 誰創建了此分類
        /// </summary>
        [ForeignKey("User")]
        [Required]
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
