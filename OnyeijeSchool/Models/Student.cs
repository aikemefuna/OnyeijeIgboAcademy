using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeSchool.Models
{
    public class Student:BaseEntity
    {
        [Key]
        [Required]
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string StudentFirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string StudentLastName { get; set; }
        [Display(Name = "Middle Name")]
        public string StudentMiddleName { get; set; }

        public Gender Gender { get; set; }

        [EmailAddress]
        public string StudentEmail { get; set; }

        [Display(Name = "Status")]
        public bool IsEnabled { get; set; }

        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string FullName
        {
            get { return StudentLastName + ", " + StudentFirstName + " " + StudentMiddleName; }
        }

        public ICollection<StAssignment> StAssignment { get; set; }

        public ICollection<StAssignmentAnswer> StAssignmentAnswer { get; set; }
        public ICollection<StCourseEnrollment> StCourseEnrollment { get; set; }
        public ICollection<StudentModule> StudentModule { get; set; }

        public ICollection<StudentTopic> StudentTopic { get; set; }
    }
}
