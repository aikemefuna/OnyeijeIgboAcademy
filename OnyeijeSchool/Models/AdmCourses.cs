using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace OnyeijeSchool.Models
{
    public class AdmCourses: BaseEntity
    {
        [Key]
        [Required]
        public int CourseId { get; set; }

        public string CourseCode { get; set; }

        [Display(Name = "Status")]
        public bool IsEnabled { get; set; }

      
        [Display(Name = "Title")]
        public string CourseTitle { get; set; }
 
        public string Description { get; set; }

        public ICollection<AdmModules> AdmModules { get; set; }
        public ICollection<StCourseEnrollment> StCourseEnrollment { get; set; }
        public ICollection<AdmClass> AdmClass { get; set; }
        public ICollection<Questions> Questions { get; set; }


        public ICollection<InstructorCourse> InstructorCourse { get; set; }
    }
}
