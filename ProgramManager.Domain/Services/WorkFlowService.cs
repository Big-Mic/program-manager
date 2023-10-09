using ProgramManager.Domain.Entities;
using ProgramManager.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Domain.Services
{
    public class WorkFlowService : IWorkFlowService
    {
        private readonly IProgramDbContext _programDbContext;
        public WorkFlowService(IProgramDbContext programDbContext)
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

        public async Task<Program> UpdateWorkflow(Guid programId, List<Stage> stages)
        {
            var program = await _programDbContext.GetById<Program>(programId);
            if (program == null)
            {
                throw new InvalidOperationException("The program cannot be found");
            }

            program.UpdateStageList(stages);
            return await _programDbContext.Update(program);
        }
    }
}
