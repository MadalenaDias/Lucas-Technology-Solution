using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models
{
	public class EntityRecordList : List<EntityRecord>
	{
		[JsonProperty(PropertyName = "total_count")]
		public int TotalCount { get; set; } = 0;
	}
}
