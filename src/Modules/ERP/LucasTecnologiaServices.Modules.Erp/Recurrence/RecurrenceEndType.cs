using LucasTecnologiaServices.Modules.Erp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Recurrence
{
	public enum RecurrenceEndType
	{
		[SelectOption(Label = "never")]
		Never = 0,
		[SelectOption(Label = "date")]
		Date = 1,
		[SelectOption(Label = "occurrences")]
		Occurrences = 2
	}
}
