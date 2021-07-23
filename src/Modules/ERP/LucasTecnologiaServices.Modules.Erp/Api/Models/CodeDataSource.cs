using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models
{
	public abstract class CodeDataSource : DataSourceBase
	{
        [JsonProperty(PropertyName = "type")]
        public override DataSourceType Type => DataSourceType.CODE;

        [JsonProperty(PropertyName = "result_model")]
		public override string ResultModel { get; set; } = "object";

		public abstract object Execute(Dictionary<string, object> arguments);
	}
}
