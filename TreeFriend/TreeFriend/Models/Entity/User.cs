﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace TreeFriend.Models.Entity {
    public class User {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        /// <summary>
        /// 是否為啟用狀態? true = 啟用，false = 停用
        /// </summary>
        [Required]
        public bool UserStatus { get; set; } = false;

        /// <summary>
        /// 是否為管理者? true = 管理者，false = 一般會員
        /// </summary>
        [Required]
        public bool UserLevel { get; set; } = false;

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Hashtag> Hashtags { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}