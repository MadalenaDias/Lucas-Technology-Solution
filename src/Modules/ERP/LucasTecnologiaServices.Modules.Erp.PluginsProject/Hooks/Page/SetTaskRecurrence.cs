using LucasTecnologiaServices.Modules.Erp.PluginsProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.PluginsProject.Hooks.Page
{
	[HookAttachment(key: "SetTaskRecurrence")]
	public class SetTaskRecurrence : IRecordDetailsPageHook
	{
		public IActionResult OnPost(RecordDetailsPageModel pageModel)
		{
			return new TaskService().SetTaskRecurrenceOnPost(pageModel);
		}
	}
}
