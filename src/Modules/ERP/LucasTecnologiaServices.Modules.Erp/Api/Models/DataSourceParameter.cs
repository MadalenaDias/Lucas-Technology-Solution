using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models
{
	public class DataSourceParameter
	{
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[JsonProperty(PropertyName = "type")]
		public string Type { get; set; }

		[JsonProperty(PropertyName = "value")]
		public string Value { get; set; }

		[JsonProperty(PropertyName = "ignore_parse_errors")]
		public bool IgnoreParseErrors { get; set; } = false;
	}
}
