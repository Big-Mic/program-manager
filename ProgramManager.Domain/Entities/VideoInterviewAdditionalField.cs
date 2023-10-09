using ProgramManager.Domain.Entities.Root;
using ProgramManager.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Domain.Entities
{
    public class VideoInterviewAdditionalField : Entity
    {
        public VideoInterviewAdditionalField()
        {
            
        }

        public VideoInterviewAdditionalField(string videoInterviewQuestion, DurationUnit durationUnit, string description, short maxDuration, short deadline)
        {
            VideoInterviewQuestion = videoInterviewQuestion;
            DurationUnit = durationUnit;
            Description = description;
            MaxDuration = maxDuration;
            Deadline = deadline;
        }

        public string VideoInterviewQuestion { get; set; }
        public DurationUnit DurationUnit { get; set; }
        public string Description { get; set; }
        public short MaxDuration { get; set; }
        public short Deadline { get; set; }
    }
}
