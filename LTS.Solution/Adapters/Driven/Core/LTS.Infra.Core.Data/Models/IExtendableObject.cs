using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Infra.Core.Data.Models
{
    public interface IExtendableObject
    {
        string ExtensionData { get; set; }

        T GetData<T>(string name, JsonSerializer jsonSerializer);
        void SetData<T>(string name, T value, JsonSerializer jsonSerializer);
    }
}
