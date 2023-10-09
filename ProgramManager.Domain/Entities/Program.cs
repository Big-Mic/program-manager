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
            Guid minimumQualificationId, Guid typeId, List<Skill> requiredSkills)
        {
            SetProperties(title, description, summary, benefits, applicationCriteria, duration, location, maximumNumberOfAppplicants, startDate, applicationOpenDate, applicationCloseDate, minimumQualificationId, typeId, requiredSkills);
            Application = new Application();
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
        public Guid MinimumQualificationId { get; set; }
        public Qualification MinimumQualification { get; set; }
        public Guid TypeId { get; set; }
        public ProgramType Type { get; set; }
        public List<Skill> RequiredSkills { get; set; }
        public Application Application { get; private set; }
        public List<Stage> Stages { get; set; }

        internal void Update(string title, string description, string summary, string benefits, string applicationCriteria, string duration, string location,
            short maximumNumberOfAppplicants, DateTime startDate, DateTime applicationOpenDate, DateTime applicationCloseDate,
            Guid minimumQualificationId, Guid typeId, List<Skill> requiredSkills)
        {
            SetProperties(title, description, summary, benefits, applicationCriteria, duration, location, maximumNumberOfAppplicants, startDate, applicationOpenDate, applicationCloseDate, minimumQualificationId, typeId, requiredSkills);
        }
        internal void SetProperties(string title, string description, string summary, string benefits, string applicationCriteria, string duration, string location,
            short maximumNumberOfAppplicants, DateTime startDate, DateTime applicationOpenDate, DateTime applicationCloseDate,
            Guid minimumQualificationId, Guid typeId, List<Skill> requiredSkills)
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
            MinimumQualificationId = minimumQualificationId;
            TypeId = typeId;
            RequiredSkills = requiredSkills;
        }
        internal void UpdateStageList(List<Stage> stages)
        {
            Stages ??= new();

            var submittedIdHash = stages.Select(x => x.Id);
            Stages.RemoveAll(x => !submittedIdHash.Contains(x.Id));
            var existingStages = Stages.ToDictionary(x => x.Id);
            foreach (var stage in stages)
            {
                if (existingStages.ContainsKey(stage.Id))
                {
                    var existingStage = existingStages[stage.Id];
                    existingStage.Update(stage);
                }
                else
                {
                    Stages.Add(stage);
                }
            }
        }

    }
}
