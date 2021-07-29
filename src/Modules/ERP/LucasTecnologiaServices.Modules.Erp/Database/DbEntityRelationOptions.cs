using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Database
{
    public class DbEntityRelationOptions
    {
        [JsonProperty(PropertyName = "relation_id")]
        public Guid? RelationId { get; set; }

        [JsonProperty(PropertyName = "relation_name")]
        public string RelationName { get; set; }

        [JsonProperty(PropertyName = "direction")]
        public string Direction { get; set; }
    }
}
