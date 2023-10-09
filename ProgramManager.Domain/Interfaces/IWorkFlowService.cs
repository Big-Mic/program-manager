using ProgramManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Domain.Interfaces
{
    public interface IWorkFlowService
    {
        Task<Program> UpdateWorkflow(Guid programId, List<Stage> stages);
    }
}
