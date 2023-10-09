using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Application.Dtos
{
    public class ProgramDto : EntityDto
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
        public QualificationDto MinimumQualification { get; set; }
        public ProgramTypeDto Type { get; set; }
        public List<SkillDto> RequiredSkills { get; set; }
        public ApplicationDto Application { get; set; }
        public List<StageDto> Stages { get; set; }


    }
}
