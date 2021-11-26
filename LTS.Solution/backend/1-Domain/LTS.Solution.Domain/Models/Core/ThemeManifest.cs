﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Domain.Models.Core
{
    public class ThemeManifest
    {
        public string Name { get; private set; }

        public string FullName { get; private set; }

        public string DisplayName { get; private set; }

        public string Version { get; private set; }
    }
}
