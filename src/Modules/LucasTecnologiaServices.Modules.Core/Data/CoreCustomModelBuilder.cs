using LucasTecnologiaServices.Infrastructure.Data;
using LucasTecnologiaServices.Modules.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Core.Data
{
    public class CoreCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppSetting>().ToTable("Core_AppSetting");
            modelBuilder.Entity<User>()
                .ToTable("Core_User");
        }
    }
}
