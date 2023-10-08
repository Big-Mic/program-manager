using ProgramManager.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Application.Interfaces
{
    public interface IProgramAppService
    {
        Task<ProgramDto> CreateProgram(ProgramCreateOrUpdateDto input);
        Task<ProgramDto> UpdateProgram(ProgramCreateOrUpdateDto input);
    }
}
