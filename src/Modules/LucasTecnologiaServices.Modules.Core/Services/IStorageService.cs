using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Core.Services
{
    public interface IStorageService
    {
        string GetMediaUrl(string fileName);

        Task SaveMediaAsync(Stream mediaBinaryStream, string fileName, string mimeType = null);

        Task DeleteMediaAsync(string fileName);
    }
}
