using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models
{
    public class QueryResult
    {
        [JsonProperty(PropertyName = "fieldsMeta")]
        public List<Field> FieldsMeta { get; set; }

        [JsonProperty(PropertyName = "data")]
        public List<EntityRecord> Data { get; set; }
    }
}
