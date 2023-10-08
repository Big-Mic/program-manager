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
    public class ProgramAppService : IProgramAppService
    {
        private readonly IProgramService _programService;
        private readonly IMapper _mapper;
        public ProgramAppService(IProgramService programService, IMapper mapper)
        {
            _programService = programService;
            _mapper = mapper;
        }
        public async Task<ProgramDto> CreateProgram(ProgramCreateOrUpdateDto input)
        {
            var qualifaction = _mapper.Map<QualificationDto, Qualification>(input.MinimumQualification);
            var skills = _mapper.Map<List<SkillDto>, List<Skill>>(input.RequiredSkills);
            var type = _mapper.Map<ProgramTypeDto, ProgramType> (input.Type);

            var resp = await _programService.CreateProgram(input.Title, input.Description, input.Summary, input.Benefits, input.ApplicationCriteria,
                input.Duration, input.Location, input.MaximumNumberOfAppplicants, input.StartDate, input.ApplicationOpenDate, input.ApplicationCloseDate, qualifaction, type, skills);
            return _mapper.Map<Program, ProgramDto>(resp);
        }

        public async Task<ProgramDto> UpdateProgram(ProgramCreateOrUpdateDto input)
        {
            if (input.Id is null)
            {
                throw new InvalidOperationException();
            }
            var qualifaction = _mapper.Map<QualificationDto, Qualification>(input.MinimumQualification);
            var skills = _mapper.Map<List<SkillDto>, List<Skill>>(input.RequiredSkills);
            var type = _mapper.Map<ProgramTypeDto, ProgramType>(input.Type);

            var resp = await _programService.UpdateProgram(input.Id.Value, input.Title, input.Description, input.Summary, input.Benefits, input.ApplicationCriteria,
                input.Duration, input.Location, input.MaximumNumberOfAppplicants, input.StartDate, input.ApplicationOpenDate, input.ApplicationCloseDate, qualifaction, type, skills);
            return _mapper.Map<Program, ProgramDto>(resp);
        }
    }
}
