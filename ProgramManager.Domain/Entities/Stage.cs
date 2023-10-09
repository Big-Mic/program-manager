using ProgramManager.Domain.Entities.Root;
using ProgramManager.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Domain.Entities
{
    public class Stage : Entity
    {
        public Stage(short order, string title, StageType type, string videoInterviewQuestion, DurationUnit durationUnit, string description, short maxDuration, short deadline)
        {
            Order = order;
            Title = title;
            Type = type;

            VideoInterviewAdditionalField = new VideoInterviewAdditionalField(videoInterviewQuestion, durationUnit, description, maxDuration, deadline);
        }

        public short Order { get; set; }
        public string Title { get; set; }
        public StageType Type { get; set; }
        public VideoInterviewAdditionalField VideoInterviewAdditionalField { get; set; }

        internal void Update(Stage stage)
        {
            Order = stage.Order;
            Title = stage.Title;
            Type = stage.Type;
            if (stage.Type == StageType.VideoInterview)
            {
                if (stage.VideoInterviewAdditionalField == null)
                {
                    throw new ArgumentNullException(nameof(stage.VideoInterviewAdditionalField));
                }
                VideoInterviewAdditionalField = stage.VideoInterviewAdditionalField;
            }
            else
            {
                VideoInterviewAdditionalField = null;
            }
        }

    }
}
