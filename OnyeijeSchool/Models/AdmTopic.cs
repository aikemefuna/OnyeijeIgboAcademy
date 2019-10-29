using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace OnyeijeSchool.Models
{
    public class AdmTopic : BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Display(Name = "Status")]
        public bool IsEnabled { get; set; }
        public string TopicNumber { get; set; }

        public string Notes { get; set; }
        
        public int ModuleId { get; set; }
        public AdmModules AdmModules { get; set; }

        public string Summary { get; set; }
        public string Title { get; set; }

        [Display(Name = "Video Url")]
        public string VideoUrl { get; set; }

        public ICollection<StudentTopic> StudentTopic { get; set; }
        public ICollection<TopicFiles> TopicFiles { get; set; }
    }
}
