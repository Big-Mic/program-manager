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
        [HttpPost]
        [Route("[controller]")]
        public async Task<ProgramDto> CreateAsync([FromBody] ProgramCreateOrUpdateDto input)
        {
            return await _programAppService.CreateProgram(input);
        } 
        [HttpPut]
        [Route("[controller]")]
        public async Task<ProgramDto> UpdateAsync([FromBody] ProgramCreateOrUpdateDto input)
        {
            return await _programAppService.UpdateProgram(input);
        } 
    }
}
