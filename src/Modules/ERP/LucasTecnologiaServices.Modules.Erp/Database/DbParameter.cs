using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Database
{
	public class DbParameter
	{
		public string Name { get; set; }

		public object Value { get; set; }

		public NpgsqlDbType Type { get; set; }
		public string ValueOverride { get; set; }
	}
}
