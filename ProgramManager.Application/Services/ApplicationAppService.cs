using AutoMapper;
using Microsoft.Extensions.Hosting;
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
    public class ApplicationAppService : IApplicationAppService
    {
        private readonly IApplicationTemplateService _applicationService;
        private readonly IProgramDbContext _programDbContext;
        private readonly IMapper _mapper;
        private readonly IFileService _fileService;
        private readonly IHostEnvironment _hostEnvironment;
        public ApplicationAppService(IApplicationTemplateService applicationService, IMapper mapper, IProgramDbContext programDbContext, IFileService fileService, IHostEnvironment hostEnvironment)
        {
            _applicationService = applicationService;
            _mapper = mapper;
            _programDbContext = programDbContext;
            _fileService = fileService;
            _hostEnvironment = hostEnvironment;
        }

        public async Task<ApplicationDto> GetApplication(Guid application)
        {
            var resp = await _programDbContext.GetById<Domain.Entities.Application>(application);
            return _mapper.Map<Domain.Entities.Application, ApplicationDto>(resp);
        }


        public async Task<ApplicationDto> UpdateApplication(ApplicationUpdateDto input)
        {
            var personalInformations = _mapper.Map<List<PersonalInformationQuestionDto>, List<PersonalInformationQuestion>>(input.PersonalInformations);
            var profileInformations = _mapper.Map<List<ProfileQuestionDto>, List<ProfileQuestion>>(input.ProfileQuestions);
            var additionalInfos = _mapper.Map<List<QuestionDto>, List<Question>>(input.AdditionalQuestions);

            Image image = await _fileService.Create(input.FileName, input.File, _hostEnvironment.ContentRootPath);
            var resp = await _applicationService.UpdateApplication(input.ProgramId, image, personalInformations, profileInformations, additionalInfos);
            return _mapper.Map<Domain.Entities.Application, ApplicationDto>(resp.Application);
        }
    }
}
