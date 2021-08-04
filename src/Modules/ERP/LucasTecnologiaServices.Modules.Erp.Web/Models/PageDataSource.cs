using LucasTecnologiaServices.Modules.Erp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Models
{
	public class PageDataSource
	{
		[JsonProperty("id")]
		public Guid Id { get; set; }

		[JsonProperty("page_id")]
		public Guid PageId { get; set; }

		[JsonProperty("data_source_id")]
		public Guid DataSourceId { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("parameters")]
		public List<DataSourceParameter> Parameters { get; set; }
	}
}
