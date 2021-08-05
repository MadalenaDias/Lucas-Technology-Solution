using LucasTecnologiaServices.Infrastructure.Data;
using LucasTecnologiaServices.Modules.Core.Models;
using LucasTecnologiaServices.Modules.Tax.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Tax.Areas.Data
{
    public class TaxCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaxClass>().HasData(new TaxClass(1) { Name = "Standard VAT" });

            modelBuilder.Entity<AppSetting>().HasData(
                new AppSetting("Tax.DefaultTaxClassId") { Module = "Tax", IsVisibleInCommonSettingPage = true, Value = "1" }
            );
        }
    }
}
