using LucasTecnologiaServices.Modules.ActivityLog.Models;
using LucasTecnologiaServices.Modules.Core.Data;
using LucasTecnologiaServices.Modules.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.ActivityLog.Data
{
    public class ActivityRepository : Repository<Activity>, IActivityTypeRepository
    {
        private const int MostViewActivityTypeId = 1;

        public ActivityRepository(LucasTechnologyDbContext context) : base(context)
        {
        }

        public IQueryable<MostViewEntityDto> List()
        {
            return from a in DbSet
                   join e in Context.Set<Entity>() on new { a.EntityId, a.EntityTypeId } equals new { e.EntityId, e.EntityTypeId }
                   where a.ActivityTypeId == MostViewActivityTypeId
                   group a by new { a.EntityId, a.EntityTypeId, e.Name, e.Slug }
                into g
                   orderby g.Count() descending
                   select new MostViewEntityDto
                   {
                       EntityTypeId = g.Key.EntityTypeId,
                       EntityId = g.Key.EntityId,
                       Name = g.Key.Name,
                       Slug = g.Key.Slug,
                       ViewedCount = g.Count()
                   };
        }
    }
}
