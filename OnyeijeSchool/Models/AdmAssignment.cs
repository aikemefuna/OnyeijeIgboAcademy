using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeSchool.Models
{
    public class AdmAssignment : BaseEntity
    {
        [Key]
        [Required]
        public int AssignmentId { get; set; }

        public string Description { get; set; }

        [Display(Name = "Status")]
        public bool IsEnabled { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }
       
        public int Id { get; set; }
        public AdmClass AdmClass { get; set; }

        public ICollection<AdmQuestions> AdmQuestions { get; set; }
        public ICollection<StAssignment> StAssignment { get; set; }
    }
}
