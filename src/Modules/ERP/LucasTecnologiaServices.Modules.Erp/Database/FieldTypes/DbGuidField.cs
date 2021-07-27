using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Database.FieldTypes
{
	public class DbGuidField : DbBaseField
	{
		[JsonProperty(PropertyName = "default_value")]
		public Guid? DefaultValue { get; set; }

		[JsonProperty(PropertyName = "generate_new_id")]
		public bool? GenerateNewId { get; set; }
	}
}
