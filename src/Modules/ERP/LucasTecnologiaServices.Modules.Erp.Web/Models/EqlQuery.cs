using LucasTecnologiaServices.Modules.Erp.Eql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Models
{
	public class EqlQuery
	{
		[JsonProperty(PropertyName = "eql")]
		public string Eql { get; set; }

		[JsonProperty(PropertyName = "parameters")]
		public List<EqlParameter> Parameters { get; set; }
	}

	public class EqlDataSourceQuery
	{
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[JsonProperty(PropertyName = "parameters")]
		public List<EqlParameter> Parameters { get; set; }
	}
}
