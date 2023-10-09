using AutoMapper;
using ProgramManager.Application.Dtos;
using ProgramManager.Application.Interfaces;
using ProgramManager.Domain.Entities;
using ProgramManager.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Application.Services
{
    public class WorkflowAppService : IWorkflowAppService
    {
        private readonly IWorkFlowService _workFlowService;
        private readonly IProgramDbContext _programDbContext;
        private readonly IMapper _mapper;
        public WorkflowAppService(IWorkFlowService workFlowService, IMapper mapper, IProgramDbContext programDbContext)
        {
            _workFlowService = workFlowService;
            _mapper = mapper;
            _programDbContext = programDbContext;
        }

        public async Task<List<StageDto>> GetStages(Guid programId)
        {
            var resp = await _programDbContext.GetById<Program>(programId);
            return _mapper.Map<List<Stage>, List<StageDto>>(resp.Stages);
        }

        public async Task<List<StageDto>> UpdateStage(WorkflowUpdateDto input)
        {
            var stages = _mapper.Map<List<StageDto>, List<Stage>>(input.Stages);
            var resp = await _workFlowService.UpdateWorkflow(input.ProgramId, stages);
            return _mapper.Map<List<Stage>, List<StageDto>>(resp.Stages);
        }
    }
}
