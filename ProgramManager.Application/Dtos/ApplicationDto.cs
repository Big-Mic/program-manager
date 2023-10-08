﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Application.Dtos
{
    public class ApplicationDto : EntityDto
    {

        public ProgramDto Program { get; set; }
        public string CoverImage { get; set; }

        public List<PersonalInformationQuestionDto> PersonalInformations { get; set; }

        public List<QuestionDto> AdditionalQuestions { get; set; }

        public List<ProfileQuestionDto> ProfileQuestions { get; set; }
        public List<StageDto> Stages { get; set; }
    }
}
