using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgramManager.Application.Dtos;
using ProgramManager.Application.Interfaces;
using ProgramManager.Domain.Interfaces;

namespace ProgramManagerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationAppService _applicationService;
        public ApplicationController( IApplicationAppService applicationService)
        {
            _applicationService = applicationService;
        }
        [HttpGet("{id}")]
        public async Task<ApplicationDto> GetAsync(Guid id)
        {
            return await _applicationService.GetApplication(id);
        } 
        [HttpPut]
        public async Task<ApplicationDto> UpdateAsync([FromBody] ApplicationUpdateDto input)
        {
            return await _applicationService.UpdateApplication(input);
        } 
    }
}
