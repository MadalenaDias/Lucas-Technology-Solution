using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Database.FieldTypes
{
	public class DbPasswordField : DbBaseField
	{
		[JsonProperty(PropertyName = "max_length")]
		public int? MaxLength { get; set; }

		[JsonProperty(PropertyName = "min_length")]
		public int? MinLength { get; set; }

		[JsonProperty(PropertyName = "encrypted")]
		public bool Encrypted { get; set; }
	}
}
