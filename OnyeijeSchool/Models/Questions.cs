using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeSchool.Models
{
    public class Questions : BaseEntity
    {
        [Key]
        [Required]
        public int QuestId { get; set; }

        public int CourseId { get; set; }
        public AdmCourses AdmCourses { get; set; }

        public string ModuleId { get; set; }
        public AdmModules AdmModules { get; set; }

        public string Instructions { get; set; }

        public string Question { get; set; }

        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string RightAnswer { get; set; }

    }
}
