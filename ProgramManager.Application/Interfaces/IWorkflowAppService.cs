using ProgramManager.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Application.Interfaces
{
    public interface IWorkflowAppService
    {
        Task<List<StageDto>> UpdateStage(WorkflowUpdateDto input);
        Task<List<StageDto>> GetStages(Guid programId);
    }
}
