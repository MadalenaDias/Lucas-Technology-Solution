using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Database.FieldTypes
{
	public class DbNumberField : DbBaseField
	{
		[JsonProperty(PropertyName = "default_value")]
		public decimal? DefaultValue { get; set; }

		[JsonProperty(PropertyName = "min_value")]
		public decimal? MinValue { get; set; }

		[JsonProperty(PropertyName = "max_value")]
		public decimal? MaxValue { get; set; }

		[JsonProperty(PropertyName = "decimal_places")]
		public byte DecimalPlaces { get; set; }
	}
}
