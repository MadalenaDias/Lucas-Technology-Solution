﻿using Abp.Configuration;
using System.Collections.Generic;

namespace LucasTechnologyServices.Services.Api.ViewModels.Manage
{
    public class UserSettingViewModel
    {
        public UserSettingViewModel()
        {
            UserSettings = new Dictionary<string, string>();
            SettingDefinitions = new Dictionary<string, SettingDefinition>();
        }

        public Dictionary<string, SettingDefinition> SettingDefinitions { get; set; }
        public Dictionary<string, string> UserSettings { get; set; }
    }
}
