using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Core.Extensions.Settings
{
    public static class SettingDefinitionExtensions
    {
        public static void AddSettingDefinitionItems(this IApplicationBuilder app, params SettingDefinition[] defaultSettings)
        {
            var settingDefinitionProvider = app.ApplicationServices.GetService<SettingDefinitionProvider>();
            settingDefinitionProvider.AddOrUpdate(defaultSettings);
        }
    }
}
