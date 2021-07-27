﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Core.Areas.ViewModels
{
    public class ThemeListItem
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string ThumbnailUrl { get; set; }

        public bool IsCurrent { get; set; }
    }
}
