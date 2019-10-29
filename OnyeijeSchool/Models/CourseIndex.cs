using System;
using System.Collections.Generic;
using System.Text;

namespace OnyeijeSchool.Models
{
   public class CourseIndex
    {
        public IEnumerable<AdmCourses> AdmCourses { get; set; }
        public IEnumerable<InstructorCourse> InstructorCourse { get; set; }
        public IEnumerable<AdmModules> AdmModules { get; set; }
        public IEnumerable<StCourseEnrollment> StCourseEnrollment { get; set; }
        public IEnumerable<AdmClass> AdmClass { get; set; }
        public IEnumerable<AdmTopic> AdmTopic { get; set; }
        public IEnumerable<Blog> Blog { get; set; }
    }
}
