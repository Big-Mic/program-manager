using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Application.Dtos
{
    public class ApplicationUpdateDto
    {
        public Guid ProgramId { get; set; }
        public string File { get; set; }
        public string FileName { get; set; }

        public List<PersonalInformationQuestionDto> PersonalInformations { get; private set; }

        public List<QuestionDto> AdditionalQuestions { get; private set; }

        public List<ProfileQuestionDto> ProfileQuestions { get; private set; }
    }
}
