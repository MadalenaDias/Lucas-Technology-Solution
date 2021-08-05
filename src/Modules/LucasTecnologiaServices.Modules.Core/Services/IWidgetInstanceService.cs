using LucasTecnologiaServices.Modules.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Core.Services
{
    public interface IWidgetInstanceService
    {
        IQueryable<WidgetInstance> GetPublished();
    }
}
