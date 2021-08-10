using LucasTecnologiaServices.Modules.Erp.Hooks;
using LucasTecnologiaServices.Modules.Erp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Hooks
{
	[Hook("Global page hooks")]
	public interface IPageHook
	{
		IActionResult OnGet(BaseErpPageModel pageModel);
		IActionResult OnPost(BaseErpPageModel pageModel);
	}
}
