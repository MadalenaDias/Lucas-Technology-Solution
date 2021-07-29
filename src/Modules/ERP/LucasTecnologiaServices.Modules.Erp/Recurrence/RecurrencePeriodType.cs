using LucasTecnologiaServices.Modules.Erp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Recurrence
{
	public enum RecurrencePeriodType
	{
		[SelectOption(Label = "second")]
		Second = 0,
		[SelectOption(Label = "minute")]
		Minute = 1,
		[SelectOption(Label = "hour")]
		Hour = 2,
		[SelectOption(Label = "day")]
		Day = 3,
		[SelectOption(Label = "week")]
		Week = 4,
		[SelectOption(Label = "month")]
		Month = 5,
		[SelectOption(Label = "year")]
		Year = 6
	}
}
