using LucasTecnologiaServices.Modules.Erp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Eql
{
	public class EqlBuildResult
	{
		public List<EqlError> Errors { get; private set; } = new List<EqlError>();
		internal EqlAbstractTree Tree { get; set; } = null;
		public List<EqlFieldMeta> Meta { get; private set; } = new List<EqlFieldMeta>();
		public List<EqlParameter> Parameters { get; private set; } = new List<EqlParameter>();
		public List<string> ExpectedParameters { get; private set; } = new List<string>();
		public Entity FromEntity { get; set; } = null;
		public string Sql { get; set; }
	}
}
