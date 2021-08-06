using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Plugin.Sdk.Model
{
	public class SitemapNodeSubmit : SitemapNode
	{
		[JsonProperty("pages")]
		public List<Guid> Pages { get; set; } = new List<Guid>();

	}
}
