using ProgramManager.Domain.Entities;
using ProgramManager.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Domain.Services
{
    public class ProgramService : IProgramService
    {
        private readonly IProgramDbContext _programDbContext;
        public ProgramService(IProgramDbContext programDbContext)
        {
            _programDbContext = programDbContext;
        }
        public async Task<Program> CreateProgram(string title, string description, string summary, string benefits, 
            string applicationCriteria, string duration, string location, short maximumNumberOfAppplicants, 
            DateTime startDate, DateTime applicationOpenDate, DateTime applicationCloseDate,
           Guid minimumQualificationId, Guid typeId, List<Skill> requiredSkills)
        {
           
           var program = new Program(title, description, summary, benefits, applicationCriteria, duration, location, 
               maximumNumberOfAppplicants, startDate, applicationOpenDate, applicationCloseDate, minimumQualificationId, typeId,
               requiredSkills);
 
           return await _programDbContext.Save(program);
        }

        public async Task<Program> UpdateProgram(Guid id, string title, string description, string summary, string benefits,
            string applicationCriteria, string duration, string location, short maximumNumberOfAppplicants, 
            DateTime startDate, DateTime applicationOpenDate, DateTime applicationCloseDate,
            Guid minimumQualificationId, Guid typeId, List<Skill> requiredSkills)
        {
            Program program = await _programDbContext.GetById<Program>(id);
            if (program != null)
            {

                program.Update(title, description, summary, benefits, applicationCriteria, duration, location,
                    maximumNumberOfAppplicants, startDate, applicationOpenDate, applicationCloseDate, minimumQualificationId, typeId, 
                    requiredSkills);

                return await _programDbContext.Update(program);
            }

            throw new InvalidOperationException();
        }


    }
}
