using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Hooks
{
	[AttributeUsage(AttributeTargets.Interface, AllowMultiple = false)]
	public class HookAttribute : Attribute
	{
		public string Description { get; private set; } = string.Empty;

		public HookAttribute(string description = "")
		{
			Description = description;
		}
	}
}
