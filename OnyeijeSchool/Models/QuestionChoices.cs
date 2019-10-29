using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeSchool.Models
{
    public class QuestionChoices : BaseEntity
    {
        [Key]
        [Required]
        public int AnswerId { get; set; }

        public bool IsAnswer { get; set; }

        public int QuestionId { get; set; }
        public AdmQuestions AdmQuestions { get; set; }
        public string Text { get; set; }
       
    }
}
