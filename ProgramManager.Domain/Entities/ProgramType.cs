using ProgramManager.Domain.Entities.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Domain.Entities
{
    public class ProgramType : Entity
    {
        public ProgramType()
        {
            
        }
        public ProgramType(string title)
        {
            Title = title;
        }
        public string Title { get; set; }
    }
}
