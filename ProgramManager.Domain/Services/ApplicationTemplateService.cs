using ProgramManager.Domain.Entities;
using ProgramManager.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Domain.Services
{
    public class ApplicationTemplateService : IApplicationTemplateService
    {
        private readonly IProgramDbContext _programDbContext;
        public ApplicationTemplateService(IProgramDbContext programDbContext)
        {
            _programDbContext = programDbContext;
        }

        public async Task<Program> UpdateApplication(Guid programId, Image coverImage, List<PersonalInformationQuestion> personalInformation, List<ProfileQuestion> profileQuestions, List<Question> additionalQuestions)
        {
            var program = await _programDbContext.GetById<Program>(programId);
            if (program == null)
            {
                throw new InvalidOperationException("The program cannot be found");
            }

            program.Application.UpdateAdditionalList(additionalQuestions);
            program.Application.UpdatePersonalInformationList(personalInformation);
            program.Application.UpdateProfileQuestionList(profileQuestions);
            if (coverImage != null)
            {
                program.Application.CoverImage = coverImage;
            }
            return await _programDbContext.Update(program);
        }
    }
}
