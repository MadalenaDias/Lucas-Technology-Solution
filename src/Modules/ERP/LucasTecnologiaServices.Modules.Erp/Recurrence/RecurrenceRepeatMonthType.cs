using LucasTecnologiaServices.Modules.Erp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Recurrence
{
	public enum RecurrenceRepeatMonthType
	{
		[SelectOption(Label = "by day")]
		ByDate = 0,
		[SelectOption(Label = "by week day")]
		ByWeekDay = 1
	}
}
