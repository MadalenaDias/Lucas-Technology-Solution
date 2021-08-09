using LucasTecnologiaServices.Modules.Erp.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Hooks
{
	[Hook("Application node page hooks")]
	public interface IApplicationNodePageHook
	{
		IActionResult OnPost(ApplicationNodePageModel pageModel);
		IActionResult OnGet(ApplicationNodePageModel pageModel);
	}
}
