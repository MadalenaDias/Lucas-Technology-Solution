using LucasTecnologiaServices.Modules.Erp.Api.Models;
using LucasTecnologiaServices.Modules.Erp.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Hooks
{
	[Hook("Login page hooks")]
	public interface ILoginPageHook
	{
		IActionResult OnPostPreLogin(LoginModel pageModel);
		IActionResult OnPostAfterLogin(ErpUser user, LoginModel pageModel);
	}
}
