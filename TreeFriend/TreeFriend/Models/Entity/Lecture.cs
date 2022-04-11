﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TreeFriend.Models.Entity
{
    public class Lecture
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LectureId { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }

        [Required]
        public string Theme { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime EventDate { get; set; }
        [Required]
        public DateTime EventTimeStart { get; set; }
        [Required]
        public DateTime EventTimeEnd { get; set; }
        [Required]
        public string Venue { get; set; }

        [Required]
        public string Speaker { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string ImgPath { get; set; }


        [Required]
        public string Description { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public bool IsDelete { get; set; } = false;
        public DateTime? UpdateTime { get; set; }

        [ForeignKey("User")]
        [Required]
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
