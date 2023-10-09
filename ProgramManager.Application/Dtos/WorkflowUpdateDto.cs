using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Application.Dtos
{
    public class WorkflowUpdateDto
    {
        public Guid ProgramId { get; set; }
        public List<StageDto> Stages { get; set; }

    }
}
