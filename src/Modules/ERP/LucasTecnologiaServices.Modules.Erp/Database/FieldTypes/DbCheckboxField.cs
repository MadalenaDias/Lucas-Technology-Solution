using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Database.FieldTypes
{
    public class DbCheckboxField : DbBaseField
    {
        [JsonProperty(PropertyName = "default_value")]
        public bool DefaultValue { get; set; }
    }
}
