using LucasTecnologiaServices.Modules.Erp.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Hooks.TestHooks
{
	[HookAttachment]
	class TestApplicationHomePageHook : IApplicationHomePageHook
	{
		public IActionResult OnGet(ApplicationHomePageModel pageModel)
		{
			return null;
		}

		public IActionResult OnPost(ApplicationHomePageModel pageModel)
		{
			return null;
		}
	}
}
