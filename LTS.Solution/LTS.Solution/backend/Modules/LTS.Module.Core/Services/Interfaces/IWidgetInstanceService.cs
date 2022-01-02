using LTS.Module.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Core.Services.Interfaces
{
    public interface IWidgetInstanceService
    {
        IQueryable<WidgetInstance> GetPublished();

    }
}
