using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Mvc;

namespace OnyeijeSchool.Models
{
    public class AdmModules: BaseEntity
    {
        [Key]
        [Required]
        public int ModuleId { get; set; }

      //  [AllowHtml]
        public string Description { get; set; }

        [Display(Name = "Status")]
        public bool IsEnabled { get; set; }

        [Display(Name = "Course")]
        public int CourseId { get; set; }

        public AdmCourses AdmCourses { get; set; }

        [Display(Name = "Module Code")]
        public string ModuleCode { get; set; }

        public string Title { get; set; }
        public ICollection<StudentModule> StudentModule { get; set; }
        public ICollection<Questions> Questions { get; set; }

    }
}
