using LucasTecnologiaServices.Modules.Erp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Components.SideBarMenu
{
	public class SidebarMenu : ViewComponent
	{
		protected ErpRequestContext ErpRequestContext { get; set; }

		public SidebarMenu([FromServices] ErpRequestContext coreReqCtx)
		{
			ErpRequestContext = coreReqCtx;
		}

		public async Task<IViewComponentResult> InvokeAsync(BaseErpPageModel pageModel)
		{
			ViewBag.SidebarMenu = pageModel.SidebarMenu;
			return await Task.FromResult<IViewComponentResult>(View("SidebarMenu"));

		}
	}
}
