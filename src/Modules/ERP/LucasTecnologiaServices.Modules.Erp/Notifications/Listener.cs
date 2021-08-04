using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Notifications
{
	internal class Listener
	{
		public string Channel { get; set; }
		public Object Instance { get; set; }
		public MethodInfo Method { get; set; }
	}
}
