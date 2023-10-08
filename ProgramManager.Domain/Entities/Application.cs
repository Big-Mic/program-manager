using ProgramManager.Domain.Entities.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Domain.Entities
{
    public class Application : Entity
    {

        public Program Program { get; set; }
        public string CoverImage { get; set; }

        public List<PersonalInformationQuestion> PersonalInformations { get; set; }

        public List<Question> AdditionalQuestions { get; set; }

        public List<ProfileQuestion> ProfileQuestions { get; set; }
        public List<Stage> Stages { get; set; }
    }
}
