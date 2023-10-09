using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgramManager.Application.Dtos;
using ProgramManager.Application.Interfaces;

namespace ProgramManagerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkflowController : ControllerBase
    {
        private readonly IWorkflowAppService _workflowAppService;
        public WorkflowController(IWorkflowAppService workflowAppService)
        {
            _workflowAppService = workflowAppService;
        }
        [HttpGet("{id}")]
        public async Task<List<StageDto>> GetAsync(Guid id)
        {
            return await _workflowAppService.GetStages(id);
        } 
        [HttpPut]
        public async Task<List<StageDto>> UpdateAsync([FromBody] WorkflowUpdateDto input)
        {
            return await _workflowAppService.UpdateStage(input);
        } 
    }
}
