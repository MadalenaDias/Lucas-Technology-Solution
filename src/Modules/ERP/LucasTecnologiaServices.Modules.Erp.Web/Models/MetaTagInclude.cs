using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Models
{
	public class MetaTagInclude
	{
		[JsonProperty("content")]
		public string Content { get; set; } = "";

		[JsonProperty("name")]
		public string Name { get; set; } = "";

		[JsonProperty("property")]
		public string Property { get; set; } = "";

		[JsonProperty("charset")]
		public string Charset { get; set; } = "";
	}
}
