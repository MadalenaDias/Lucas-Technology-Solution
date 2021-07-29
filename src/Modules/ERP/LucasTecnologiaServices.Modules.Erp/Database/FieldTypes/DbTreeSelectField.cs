using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Database.FieldTypes
{
	public class DbTreeSelectField : DbBaseField
	{
		[JsonProperty(PropertyName = "related_entity_id")]
		public Guid RelatedEntityId { get; set; }

		[JsonProperty(PropertyName = "relation_id")]
		public Guid RelationId { get; set; }

		[JsonProperty(PropertyName = "selected_tree_id")]
		public Guid SelectedTreeId { get; set; }

		[JsonProperty(PropertyName = "selection_type")]
		public string SelectionType { get; set; }

		[JsonProperty(PropertyName = "selection_target")]
		public string SelectionTarget { get; set; }
	}
}
