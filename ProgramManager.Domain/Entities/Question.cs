using ProgramManager.Domain.Entities.Root;
using ProgramManager.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Domain.Entities
{
    public class Question : Entity
    {
        public QuestionType Type { get; set; }

        public string Title  { get; set; }

        public short Order { get; set; }
        internal void Update(Question question)
        {
            Type = question.Type;
            Title = question.Title;
        }
    }
}
