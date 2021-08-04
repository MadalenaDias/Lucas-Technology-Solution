using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Models
{
	public class PageSwitchItem
	{
		[JsonProperty("label")]
		public string Label { get; set; } = "";

		[JsonProperty("url")]
		public string Url { get; set; } = "";

		[JsonProperty("is_selected")]
		public bool IsSelected { get; set; } = false;

	}
}
