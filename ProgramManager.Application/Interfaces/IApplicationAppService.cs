using ProgramManager.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Application.Interfaces
{
    public interface IApplicationAppService
    {
        Task<ApplicationDto> UpdateApplication(ApplicationUpdateDto input);
        Task<ApplicationDto> GetApplication(Guid application);
    }
}
