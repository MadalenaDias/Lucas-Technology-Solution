using LucasTecnologiaServices.Modules.Erp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Components.UserMenu
{
	public class UserMenu : ViewComponent
	{
		protected ErpRequestContext ErpRequestContext { get; set; }

		public UserMenu([FromServices] ErpRequestContext coreReqCtx)
		{
			ErpRequestContext = coreReqCtx;
		}

		public async Task<IViewComponentResult> InvokeAsync(BaseErpPageModel pageModel)
		{
			ViewBag.UserMenu = pageModel.UserMenu;
			return await Task.FromResult<IViewComponentResult>(View("UserMenu"));

		}
	}
}
