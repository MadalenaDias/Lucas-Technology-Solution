using LucasTecnologiaServices.Modules.Core.Areas.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Core.Services
{
    public interface IThemeService
    {
        Task<IList<ThemeListItem>> GetInstalledThemes();

        Task SetCurrentTheme(string themeName);

        string PackTheme(string themeName);

        Task Install(Stream stream, string themeName);

        void Delete(string themeName);
    }
}
