using LucasTecnologiaServices.Modules.Erp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Components.SiteMenu
{
	public class SiteMenu : ViewComponent
	{
		protected ErpRequestContext ErpRequestContext { get; set; }

		public SiteMenu([FromServices] ErpRequestContext coreReqCtx)
		{
			ErpRequestContext = coreReqCtx;
		}

		public async Task<IViewComponentResult> InvokeAsync(BaseErpPageModel pageModel)
		{
			ViewBag.SiteMenu = pageModel.SiteMenu;
			return await Task.FromResult<IViewComponentResult>(View("SiteMenu"));
		}
	}
}
