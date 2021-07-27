using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models
{
	public class DatabaseNNRelationRecord
	{
		[JsonProperty(PropertyName = "origin_id")]
		public Guid OriginId { get; set; }

		[JsonProperty(PropertyName = "target_id")]
		public Guid TargetId { get; set; }

	}
}
