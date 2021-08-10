using LucasTecnologiaServices.Modules.Erp.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Hooks
{
	[Hook("Index page hooks")]
	public interface IHomePageHook
	{
		IActionResult OnGet(HomePageModel pageModel);
		IActionResult OnPost(HomePageModel pageModel);
	}
}
