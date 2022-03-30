﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TreeFriend.Models.Entity {
    public class UserDetail {
        [Key]
        [ForeignKey("User")]
        public int UserId { get; set; }

        public string UserName { get; set; }

        public bool Sex { get; set; }

        public DateTime Birthday { get; set; }

        public string SelfIntrodution { get; set; }

        public string HeadshotPath { get; set; } = "~/icon/headshot.jpg";

        public User User { get; set; }
    }
}