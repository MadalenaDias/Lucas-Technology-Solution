using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Database
{
	public abstract class DbDocumentBase
	{
		[JsonProperty(PropertyName = "id")]
		public Guid Id { get; set; }
	}
}
