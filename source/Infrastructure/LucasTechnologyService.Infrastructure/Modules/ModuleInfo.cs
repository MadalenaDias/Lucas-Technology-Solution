using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyService.Infrastructure.Modules
{
    public class ModuleInfo
    {
        public string Id { get; private set; }

        public string Name { get; private set; }

        public bool IsBundledWithHost { get; private set; }

        public Version Version { get; private set; }

        public Assembly Assembly { get; private set; }
    }
}
