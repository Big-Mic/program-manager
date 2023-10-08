using ProgramManager.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Application.Dtos
{
    public class VideoInterviewAdditionalFieldDto : EntityDto
    {
        public string VideoInterviewQuestion { get; set; }
        public DurationUnit DurationUnit { get; set; }
        public string Description { get; set; }
        public short MaxDuration { get; set; }
        public short Deadline { get; set; }
    }
}
