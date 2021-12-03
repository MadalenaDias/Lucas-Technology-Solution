using LTS.Solution.Domain.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Domain.Contracts.Core
{
    public interface IThemeManifestRepository
    {
        Task<ThemeManifest> GetById(Guid id);

        Task<ThemeManifest> GetByName(string name);

        Task<ThemeManifest> GetByVersion(string version);

        void Add(ThemeManifest themeManifest);

        void Update(ThemeManifest themeManifest);

        void Remove(ThemeManifest themeManifest);
        
    }
}
