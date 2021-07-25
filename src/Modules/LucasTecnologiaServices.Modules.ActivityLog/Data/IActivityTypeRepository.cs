using LucasTecnologiaServices.Infrastructure.Data;
using LucasTecnologiaServices.Modules.ActivityLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.ActivityLog.Data
{
    public interface IActivityTypeRepository : IRepository<Activity>
    {
        IQueryable<MostViewEntityDto> List();
    }
}
