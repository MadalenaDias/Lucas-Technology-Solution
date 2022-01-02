using LTS.Module.Core.Data.EFCore;
using LTSSolution.Infrastructure.Data;
using LTSSolution.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Core.Data
{
    public class Repository<T> : RepositoryWithTypedId<T, long>, IRepository<T>
       where T : class, IEntityWithTypedId<long>
    {
        public Repository(CoreDbContext context) : base(context)
        {
        }
    }
}
