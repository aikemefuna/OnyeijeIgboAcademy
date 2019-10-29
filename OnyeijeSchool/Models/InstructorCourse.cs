using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnyeijeSchool.Models
{
   public class InstructorCourse :BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public int CourseId { get; set; }
        public AdmCourses AdmCourses { get; set; }

       
    }
}
