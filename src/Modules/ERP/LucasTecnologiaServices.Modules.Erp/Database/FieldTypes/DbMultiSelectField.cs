using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Database.FieldTypes
{
	public class DbMultiSelectField : DbBaseField
	{
		[JsonProperty(PropertyName = "default_value")]
		public IEnumerable<string> DefaultValue { get; set; }

		[JsonProperty(PropertyName = "options")]
		public IList<DbSelectOption> Options { get; set; }
	}
}
