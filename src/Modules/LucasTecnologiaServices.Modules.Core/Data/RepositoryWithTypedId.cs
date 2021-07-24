using LucasTecnologiaServices.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Core.Data
{
    public class RepositoryWithTypedId<T, TId> where T : class, IEntityWithTypedId<TId>
    {
        public RepositoryWithTyoedId(LucasTechnologyDbContext)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }

        protected DbContext Context { get; }
        protected DbSet<T> DbSet { get; }
        public void Add(T entity)
        {

        }
    }
}
