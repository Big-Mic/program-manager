using ProgramManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Domain.Interfaces
{
    public interface IProgramService
    {
        Task<Program> CreateProgram(string title, string description, string summary, string benefits, string applicationCriteria, string duration, string location,
             short maximumNumberOfAppplicants, DateTime startDate, DateTime applicationOpenDate, DateTime applicationCloseDate,
             Guid minimumQualification, Guid type, List<Skill> requiredSkills);
        Task<Program> UpdateProgram(Guid id, string title, string description, string summary, string benefits, string applicationCriteria, string duration, string location,
             short maximumNumberOfAppplicants, DateTime startDate, DateTime applicationOpenDate, DateTime applicationCloseDate,
             Guid minimumQualification, Guid type, List<Skill> requiredSkills);
    }
}
