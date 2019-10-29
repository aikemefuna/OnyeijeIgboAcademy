﻿
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeSchool.Models
{
    public class Instructor : BaseEntity
    {
        [Key]
        [Required]
        public int InstructorId { get; set; }

        [Required]
        [RegularExpression("^[a-z A-Z]*$", ErrorMessage = "Only Alphabets allowed")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Surname")]
        [RegularExpression("^[a-z A-Z]*$", ErrorMessage = "Only Alphabets allowed")]
        public string SurName { get; set; }
    
        [Display(Name = "Other Names")]
        [RegularExpression("^[a-z A-Z]*$", ErrorMessage = "Only Alphabets allowed")]
        public string  OtherNames { get; set; }
   
        [Display(Name = "Prefered Names")]
        [RegularExpression("^[a-z A-Z]*$", ErrorMessage = "Only Alphabets allowed")]
        public string  PreferedName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string InstructorEmail { get; set; }
      
        [Required]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please enter a valid Phone number")]
        [RegularExpression("^[+0-9]*$", ErrorMessage = "Input a valid Phone Number.")]
        [MaxLength(15, ErrorMessage = "Lenght Exceeded..")]
       
        public string PhoneNumber { get; set; }

        [Required]
        [RegularExpression("^[a-z A-Z]*$", ErrorMessage = "Only Alphabets allowed")]
        public string Country { get; set; }
       
       public string FullName
        {
            get { return SurName + " ," + FirstName + " "+ OtherNames; }
        }

        public ICollection<InstructorCourse> InstructorCourse { get; set; }

    }
}
