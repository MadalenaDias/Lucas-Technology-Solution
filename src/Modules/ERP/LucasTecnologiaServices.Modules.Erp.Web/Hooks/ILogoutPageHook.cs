using LucasTecnologiaServices.Modules.Erp.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Hooks
{
	[Hook("Logout page hooks")]
	public interface ILogoutPageHook
	{
		IActionResult OnGet(LogoutModel pageModel);
		IActionResult OnPost(LogoutModel pageModel);
	}
}
