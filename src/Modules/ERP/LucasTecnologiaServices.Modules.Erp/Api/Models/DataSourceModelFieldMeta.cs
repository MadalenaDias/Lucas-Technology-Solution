using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models
{
	public class DataSourceModelFieldMeta
	{
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[JsonProperty(PropertyName = "type")]
		public FieldType Type { get; set; }

		[JsonProperty(PropertyName = "entity_name")]
		public string EntityName { get; set; }

		[JsonProperty(PropertyName = "relation_name")]
		public string RelationName { get; set; }

		[JsonProperty(PropertyName = "children")]
		public List<DataSourceModelFieldMeta> Children { get; private set; } = new List<DataSourceModelFieldMeta>();

		public DataSourceModelFieldMeta() { }

		public DataSourceModelFieldMeta(EqlFieldMeta fieldMeta)
		{
			Name = fieldMeta.Name;
			if (fieldMeta.Field != null)
			{
				EntityName = fieldMeta.Field.EntityName;
				Type = fieldMeta.Field.GetFieldType();
			}
			else
			{
				RelationName = fieldMeta.Relation.Name;
				Type = FieldType.RelationField;
			}
			foreach (var child in fieldMeta.Children)
				Children.Add(new DataSourceModelFieldMeta(child));

		}
	}
}
