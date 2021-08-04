using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Models
{
	public class UrlInfo
	{
		[JsonProperty("has_relation")]
		public bool HasRelation { get; set; } = false;

		[JsonProperty("page_type")]
		public PageType PageType { get; set; } = PageType.Site;

		[JsonProperty("app_name")]
		public string AppName { get; set; } = "";

		[JsonProperty("area_name")]
		public string AreaName { get; set; } = "";

		[JsonProperty("node_name")]
		public string NodeName { get; set; } = "";

		[JsonProperty("page_name")]
		public string PageName { get; set; } = "";

		[JsonProperty("record_id")]
		public Guid? RecordId { get; set; } = null;

		[JsonProperty("relation_id")]
		public Guid? RelationId { get; set; } = null;

		[JsonProperty("parent_record_id")]
		public Guid? ParentRecordId { get; set; } = null;

	}
}
