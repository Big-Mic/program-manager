using ProgramManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Domain.Interfaces
{
    public interface IApplicationTemplateService
    {
        Task<Program> UpdateApplication(Guid programId, Image coverImage, List<PersonalInformationQuestion> personalInformation, List<ProfileQuestion> profileQuestions, List<Question> additionalQuestions);
    }
}
