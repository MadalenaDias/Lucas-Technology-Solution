using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models
{
	public class QueryResponse : BaseResponseModel
	{
		public QueryResponse()
		{
			Object = new QueryResult();
		}

		[JsonProperty(PropertyName = "object")]
		public QueryResult Object { get; set; }
	}
}
