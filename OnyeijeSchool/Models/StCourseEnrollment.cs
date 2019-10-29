using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeSchool.Models
{
    public class StCourseEnrollment : BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Display(Name = "Approval Status")]
        public bool IsApproved { get; set; }

        [Display(Name = "Completed Status")]
        public bool IsCompleted { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public AdmCourses AdmCourses { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ApprovedDate { get; set; }

    }
}