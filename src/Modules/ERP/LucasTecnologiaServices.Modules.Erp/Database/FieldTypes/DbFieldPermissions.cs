using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Database.FieldTypes
{
    public class DbFieldPermissions
    {
        [JsonProperty(PropertyName = "can_read")]
        public List<Guid> CanRead { get; set; }

        [JsonProperty(PropertyName = "can_update")]
        public List<Guid> CanUpdate { get; set; }

        public DbFieldPermissions()
        {
            CanRead = new List<Guid>();
            CanUpdate = new List<Guid>();
        }
    }
}
