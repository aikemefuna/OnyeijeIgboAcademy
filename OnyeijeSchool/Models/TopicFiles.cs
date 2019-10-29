using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeSchool.Models

{
    public class TopicFiles : BaseEntity
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public int Topic { get; set; }

        public virtual AdmTopic AdmTopic { get; set; }
    }
}
