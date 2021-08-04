using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Models
{
	public class KeyStringList
	{
		[JsonProperty(PropertyName = "key")]
		public string Key { get; set; } = "";

		[JsonProperty(PropertyName = "values")]
		public List<string> Values { get; set; } = new List<string>();
	}
}
