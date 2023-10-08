using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Application.Dtos
{
    public class PersonalInformationQuestionDto : QuestionDto
    {

        public bool IsInternal { get; set; }

        public bool IsHidden { get; set; }


    }
}
