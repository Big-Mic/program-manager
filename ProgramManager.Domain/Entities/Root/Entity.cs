using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  ProgramManager.Domain.Entities.Root
{
    public class Entity : IEntity
    {
        [Key]
        public virtual Guid Id { get; set; }
    }
}
