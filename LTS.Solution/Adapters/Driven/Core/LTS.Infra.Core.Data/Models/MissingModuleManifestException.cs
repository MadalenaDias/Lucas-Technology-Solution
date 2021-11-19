using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD:LTS.Solution/Adapters/Driven/Core/LTS.Infra.Core.Data/Models/MissingModuleManifestException.cs
namespace LTS.Infra.Core.Data.Models
=======
namespace LucasTechnologyService.Infrastructure.Models
>>>>>>> origin/dev:source/Infrastructure/LucasTechnologyService.Infrastructure/Models/MissingModuleManifestException.cs
{
    public class MissingModuleManifestException : Exception
    {
        public string ModuleName { get; }

        public MissingModuleManifestException()
        {

        }

        public MissingModuleManifestException(string message)
            : base(message)
        {

        }

        public MissingModuleManifestException(string message, string moduleName)
            : this(message)
        {
            ModuleName = moduleName;
        }
    }
}
