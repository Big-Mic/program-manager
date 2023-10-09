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

        public List<PersonalInformationQuestionDto> PersonalInformations { get; set; }

        public List<QuestionDto> AdditionalQuestions { get; set; }

        public List<ProfileQuestionDto> ProfileQuestions { get; set; }
    }
}
