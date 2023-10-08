using ProgramManager.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Application.Dtos
{
    public class QuestionDto : EntityDto
    {
        public QuestionType Type { get; set; }

        public string Title  { get; set; }

        public short Order { get; set; }
    }
}
