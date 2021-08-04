using LucasTecnologiaServices.Modules.Erp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Recurrence
{
	public enum RecurrenceChangeType
	{
		[SelectOption(Label = "only this")]
		OnlyThis = 0,
		[SelectOption(Label = "this and all that follow")]
		ThisAndAllFollowingThis = 1,
		[SelectOption(Label = "all from this template")]
		All = 2
	}
}
