using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models
{
    public class SystemSettings
    {
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }

        [JsonProperty(PropertyName = "version")]
        public int Version { get; set; }

        public SystemSettings()
        {

        }

        public SystemSettings(DbSystemSettings settings)
        {
            Id = settings.Id;
            Version = settings.Version;
        }
    }
}
