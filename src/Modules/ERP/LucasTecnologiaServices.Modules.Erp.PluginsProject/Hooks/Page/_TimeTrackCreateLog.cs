using LucasTecnologiaServices.Modules.Erp.PluginsProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.PluginsProject.Hooks.Page
{
	[HookAttachment(key: "TimeTrackCreateLog")]
	public class _TimeTrackCreateLog : IApplicationNodePageHook
	{

		public IActionResult OnGet(ApplicationNodePageModel pageModel)
		{
			return null;
		}

		public IActionResult OnPost(ApplicationNodePageModel pageModel)
		{
			return new TimeLogService().PostApplicationNodePageHookLogic(pageModel);
		}
	}
}
