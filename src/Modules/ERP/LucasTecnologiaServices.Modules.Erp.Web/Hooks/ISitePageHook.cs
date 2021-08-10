using LucasTecnologiaServices.Modules.Erp.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Hooks
{
	[Hook("Site page hooks")]
	public interface ISitePageHook
	{
		IActionResult OnGet(SitePageModel pageModel);
		IActionResult OnPost(SitePageModel pageModel);
	}
}
