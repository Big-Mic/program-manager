using ProgramManager.Domain.Entities.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Domain.Entities
{
    public class Program : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public string Benefits { get; set; }
        public string ApplicationCriteria { get; set; }
        public string Duration { get; set; }
        public string Location { get; set; }
        public short MaximumNumberOfAppplicants { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ApplicationOpenDate { get; set; }
        public DateTime ApplicationCloseDate { get; set; }
        public Qualification MinimumQualification { get; set; }
        public ProgramType Type { get; set; }
        public List<Skill> RequiredSkills { get; set; }

    }
}
