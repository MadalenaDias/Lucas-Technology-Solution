using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Database.FieldTypes
{
	public class DbAutoNumberField : DbBaseField
	{
		[JsonProperty(PropertyName = "default_value")]
		public decimal? DefaultValue { get; set; }

		[JsonProperty(PropertyName = "display_format")]
		public string DisplayFormat { get; set; }

		[JsonProperty(PropertyName = "starting_number")]
		public decimal? StartingNumber { get; set; }
	}
}
