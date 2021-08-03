using LucasTecnologiaServices.Infrastructure.Data;
using LucasTecnologiaServices.Modules.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Contacts.Data
{
    public class ContactCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppSetting>().HasData(
                new AppSetting("GoogleAppKey") { Module = "Contact", IsVisibleInCommonSettingPage = false, Value = "" }
            );
        }
    }
}
