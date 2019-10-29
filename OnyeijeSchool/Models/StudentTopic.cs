﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeSchool.Models

{
    public class StudentTopic: BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Display(Name = "Completed Status")]
        public bool IsCompleted { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int Topicid { get; set; }
        public AdmTopic AdmTopic { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? CompletedTime { get; set; }
    }
}
