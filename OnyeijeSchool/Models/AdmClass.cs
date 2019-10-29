using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnyeijeSchool.Models
{
    public class AdmClass: BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Display(Name = "Class")]
        public string ClassName { get; set; }
        public int CourseId { get; set; }
        public AdmCourses AdmCourses { get; set; }

        [Display(Name ="Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Status")]
        public bool IsActive { get; set; }

        public ICollection<AdmAssignment> AdmAssignment { get; set; }
        public ICollection<ExamSetUp> ExamSetUp { get; set; }

    }
}
