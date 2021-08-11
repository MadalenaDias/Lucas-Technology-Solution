using LucasTecnologiaServices.Modules.Erp.Web.Models;
using LucasTecnologiaServices.Modules.Erp.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Components.ApplicationMenu
{
	public class ApplicationMenu : ViewComponent
	{
		protected ErpRequestContext ErpRequestContext { get; set; }

		public ApplicationMenu([FromServices] ErpRequestContext coreReqCtx)
		{
			ErpRequestContext = coreReqCtx;
		}

		public async Task<IViewComponentResult> InvokeAsync(BaseErpPageModel pageModel)
		{
			var areaList = pageModel.ApplicationMenu;
			foreach (var area in areaList)
			{
				area.Nodes = new RenderService().ConvertListToTree(area.Nodes, new List<MenuItem>(), null);
			}

			ViewBag.ApplicationMenu = areaList;
			return await Task.FromResult<IViewComponentResult>(View("ApplicationMenu"));
		}
	}
}
