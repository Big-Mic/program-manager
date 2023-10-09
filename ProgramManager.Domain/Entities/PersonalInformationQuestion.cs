using ProgramManager.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Domain.Entities
{
    public class PersonalInformationQuestion : Question
    {
        public PersonalInformationQuestion()
        {
            
        }

        public PersonalInformationQuestion( short order, string title, QuestionType questionType = QuestionType.ShortAnswer, bool isInternal = false, bool isHidden = false)
        {
            Order = order;
            Title = title;
            Type = questionType;
            IsInternal = isInternal;
            IsHidden = isHidden;
        }
        internal void Update(PersonalInformationQuestion personalInformationQuestion)
        {
            Title = personalInformationQuestion.Title;
            Type = personalInformationQuestion.Type;
            Order = personalInformationQuestion.Order;
            IsInternal = personalInformationQuestion.IsInternal;
            IsHidden = personalInformationQuestion.IsHidden;
        }

        public bool IsInternal { get; set; }

        public bool IsHidden { get; set; }


    }
}
