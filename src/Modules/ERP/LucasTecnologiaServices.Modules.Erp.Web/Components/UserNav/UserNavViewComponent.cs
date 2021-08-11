using LucasTecnologiaServices.Modules.Erp.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Components.UserNav
{
	public class UserNavViewComponent : ViewComponent
	{
		protected ErpRequestContext ErpRequestContext { get; set; }

		public UserNavViewComponent([FromServices] ErpRequestContext coreReqCtx)
		{
			ErpRequestContext = coreReqCtx;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var pageContext = ErpRequestContext.PageContext;
			ViewBag.CurrentUser = AuthService.GetUser(UserClaimsPrincipal);
			ViewBag.PageId = null;
			if (ErpRequestContext.Page != null)
			{
				ViewBag.PageId = ErpRequestContext.Page.Id;
			}

			return await Task.FromResult<IViewComponentResult>(View("UserNav.Default"));
		}
	}
}
