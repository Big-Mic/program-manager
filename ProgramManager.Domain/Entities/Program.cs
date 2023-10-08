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
        public Program()
        {
        }

        public Program(string title, string description, string summary, string benefits, string applicationCriteria, string duration, string location, 
            short maximumNumberOfAppplicants, DateTime startDate, DateTime applicationOpenDate, DateTime applicationCloseDate, 
            Qualification minimumQualification, ProgramType type, List<Skill> requiredSkills)
        {
            SetProperties(title, description, summary, benefits, applicationCriteria, duration, location, maximumNumberOfAppplicants, startDate, applicationOpenDate, applicationCloseDate, minimumQualification, type, requiredSkills);
        }

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

        internal void Update(string title, string description, string summary, string benefits, string applicationCriteria, string duration, string location,
            short maximumNumberOfAppplicants, DateTime startDate, DateTime applicationOpenDate, DateTime applicationCloseDate,
            Qualification minimumQualification, ProgramType type, List<Skill> requiredSkills)
        {
            SetProperties(title, description, summary, benefits, applicationCriteria, duration, location, maximumNumberOfAppplicants, startDate, applicationOpenDate, applicationCloseDate, minimumQualification, type, requiredSkills);
        }
        internal void SetProperties(string title, string description, string summary, string benefits, string applicationCriteria, string duration, string location,
            short maximumNumberOfAppplicants, DateTime startDate, DateTime applicationOpenDate, DateTime applicationCloseDate,
            Qualification minimumQualification, ProgramType type, List<Skill> requiredSkills)
        {
            Title = title;
            Description = description;
            Summary = summary;
            Benefits = benefits;
            ApplicationCriteria = applicationCriteria;
            Duration = duration;
            Location = location;
            MaximumNumberOfAppplicants = maximumNumberOfAppplicants;
            StartDate = startDate;
            ApplicationOpenDate = applicationOpenDate;
            ApplicationCloseDate = applicationCloseDate;
            MinimumQualification = minimumQualification;
            Type = type;
            RequiredSkills = requiredSkills;
        }


    }
}
