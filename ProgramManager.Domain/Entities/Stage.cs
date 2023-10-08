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
        public Guid ApplicationId { get; set; }
        public short Order { get; set; }
        public string Title { get; set; }
        public StageType Type { get; set; }
        public VideoInterviewAdditionalField VideoInterviewAdditionalField { get; set; }

    }
}
