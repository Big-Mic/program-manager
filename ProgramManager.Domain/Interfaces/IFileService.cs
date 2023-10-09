using ProgramManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Domain.Interfaces
{
    public interface IFileService
    {
        Task<Image> Create(string fileName, string file, string uploadBasePath);
    }
}
