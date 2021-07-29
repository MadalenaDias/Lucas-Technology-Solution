using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Database.FieldTypes
{
	public class DbSelectField : DbBaseField
	{
		[JsonProperty(PropertyName = "default_value")]
		public string DefaultValue { get; set; }

		[JsonProperty(PropertyName = "options")]
		public IList<DbSelectOption> Options { get; set; }
	}

	public class DbSelectOption
	{
		[JsonProperty(PropertyName = "label")]
		public string Label { get; set; } = "";

		[JsonProperty(PropertyName = "value")]
		public string Value { get; set; } = "";

		[JsonProperty(PropertyName = "icon_class")]
		public string IconClass { get; set; } = "";

		[JsonProperty(PropertyName = "color")]
		public string Color { get; set; } = "";
	}
}
