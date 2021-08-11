using LucasTecnologiaServices.Modules.Erp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Components.ToobarMenu
{
	public class ToobarMenu : ViewComponent
	{
		protected ErpRequestContext ErpRequestContext { get; set; }

		public ToobarMenu([FromServices] ErpRequestContext coreReqCtx)
		{
			ErpRequestContext = coreReqCtx;
		}

		public async Task<IViewComponentResult> InvokeAsync(BaseErpPageModel pageModel)
		{
			ViewBag.ToolbarMenu = pageModel.ToolbarMenu;
			return await Task.FromResult<IViewComponentResult>(View("ToobarMenu"));
		}
	}
}
