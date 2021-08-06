using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Plugin.Sdk.Model
{
	public class AreaSelectionTree
	{
		[JsonProperty(PropertyName = "area_id")]
		public Guid AreaId { get; set; } = Guid.Empty;

		[JsonProperty(PropertyName = "all_nodes")]
		public List<SelectOption> AllNodes { get; set; } = new List<SelectOption>();
	}
}
