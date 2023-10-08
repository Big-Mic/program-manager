using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Domain.Entities
{
    public class PersonalInformationQuestion : Question
    {

        public bool IsInternal { get; set; }

        public bool IsHidden { get; set; }


    }
}
