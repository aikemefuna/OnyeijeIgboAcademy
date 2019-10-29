using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeSchool.Models
{
    public class StAssignmentAnswer: BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public int Choice { get; set; }

        public string Essay { get; set; }
        public int QuestionId { get; set; }

        public AdmQuestions AdmQuestions { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
