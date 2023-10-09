using ProgramManager.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Domain.Entities
{
    public class ProfileQuestion : Question
    {
        public ProfileQuestion()
        {
            
        }
        public ProfileQuestion(short order, string title, QuestionType questionType = QuestionType.ShortAnswer,bool isMandatory = false, bool isHidden = false)
        {
            Order = order;
            Title = title;
            Type = questionType;
            IsMandatory = isMandatory;
            IsHidden = isHidden;
        }
        internal void Update(ProfileQuestion profileQuestion)
        {
            Title = profileQuestion.Title;
            Type = profileQuestion.Type;
            Order = profileQuestion.Order;
            IsMandatory = profileQuestion.IsMandatory;
            IsHidden = profileQuestion.IsHidden;
        }
        public bool IsMandatory { get; set; }
        public bool IsHidden { get; set; }

    }
}
