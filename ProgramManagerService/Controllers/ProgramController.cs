using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgramManager.Application.Dtos;
using ProgramManager.Application.Interfaces;

namespace ProgramManagerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramController : ControllerBase
    {
        private readonly IProgramAppService _programAppService;
        public ProgramController(IProgramAppService programAppService)
        {
            _programAppService = programAppService;
        }
        [HttpGet("{id}")]
        public async Task<ProgramDto> GetAsync(Guid id)
        {
            return await _programAppService.GetProgram(id);
        } 
        [HttpPost]
        public async Task<ProgramDto> CreateAsync([FromBody] ProgramCreateOrUpdateDto input)
        {
            return await _programAppService.CreateProgram(input);
        } 
        [HttpPut]
        public async Task<ProgramDto> UpdateAsync([FromBody] ProgramCreateOrUpdateDto input)
        {
            return await _programAppService.UpdateProgram(input);
        } 
    }
}
