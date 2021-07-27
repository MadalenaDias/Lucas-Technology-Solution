using LucasTecnologiaServices.Modules.Erp.Api.Models;
using LucasTecnologiaServices.Modules.Erp.Api.Models.FieldType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Eql
{
	public class EqlFieldMeta
	{
		public string Name { get; set; }

		public Field Field { get; set; } = null;

		public EntityRelation Relation { get; set; } = null;

		public List<EqlFieldMeta> Children { get; private set; } = new List<EqlFieldMeta>();

		public override string ToString()
		{
			return Name;
		}
	}
}
