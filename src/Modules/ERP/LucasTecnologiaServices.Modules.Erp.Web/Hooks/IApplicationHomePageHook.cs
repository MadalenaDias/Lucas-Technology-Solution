using LucasTecnologiaServices.Modules.Erp.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Hooks
{
	[Hook("Application home page hooks")]
	public interface IApplicationHomePageHook
	{
		IActionResult OnGet(ApplicationHomePageModel pageModel);
		IActionResult OnPost(ApplicationHomePageModel pageModel);
	}
}
