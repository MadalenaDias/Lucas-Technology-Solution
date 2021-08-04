using LucasTecnologiaServices.Modules.Erp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Models
{
	public class DataSourceTestModel
	{
		[JsonProperty(PropertyName = "action")]
		public string Action { get; set; }

		[JsonProperty(PropertyName = "eql")]
		public string Eql { get; set; }

		[JsonProperty(PropertyName = "parameters")]
		public string Parameters { get; set; }

		[JsonProperty(PropertyName = "param_list")]
		public List<DataSourceParameter> ParamList { get; set; }
	}
}
