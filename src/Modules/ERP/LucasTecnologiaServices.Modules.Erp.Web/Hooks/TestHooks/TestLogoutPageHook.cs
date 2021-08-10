using LucasTecnologiaServices.Modules.Erp.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Hooks.TestHooks
{
	[HookAttachment]
	class TestLogoutPageHook : ILogoutPageHook
	{
		public IActionResult OnGet(LogoutModel pageModel)
		{
			return null;
		}
		public IActionResult OnPost(LogoutModel pageModel)
		{
			return null;
		}

	}
}
