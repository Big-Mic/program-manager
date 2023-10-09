using Microsoft.EntityFrameworkCore;
using ProgramManager.Domain.Entities.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Domain.Interfaces
{
    public interface IProgramDbContext
    {
        Task<T> GetById<T>(Guid id) where T: Entity;
        Task<T> Save<T>(T obj) where T : Entity;
        Task<T> Update<T>(T obj) where T : Entity;
        Task<DbSet<T>> GetDbSet<T>() where T : Entity;
        Task<List<T>> GetByIds<T>(List<Guid> ids) where T : Entity;
    }
}
