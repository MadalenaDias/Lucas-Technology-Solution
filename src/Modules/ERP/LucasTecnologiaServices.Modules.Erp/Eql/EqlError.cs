using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Eql
{
	public class EqlError
	{
		public string Message { get; set; }
		public int? Line { get; set; }
		public int? Column { get; set; }
	}
}
