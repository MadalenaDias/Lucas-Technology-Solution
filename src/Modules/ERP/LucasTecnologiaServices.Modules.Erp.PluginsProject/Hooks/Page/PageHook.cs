using LucasTecnologiaServices.Modules.Erp.PluginsProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.PluginsProject.Hooks.Page
{
	[HookAttachment]
	public class PageHook : IPageHook
	{
		private Guid CREATE_TASK_PAGE_ID = new Guid("68100014-1fd7-456c-9b26-27aa9f858287");

		public IActionResult OnGet(BaseErpPageModel pageModel)
		{
			var page = pageModel.ErpRequestContext.Page;

			// Init task create form
			if (page != null && page.Id == CREATE_TASK_PAGE_ID)
			{
				EntityRecord record = (EntityRecord)pageModel.DataModel.GetProperty("Record");

				var resultRecord = new TaskService().GetPageHookLogic(pageModel, record);

				pageModel.DataModel.SetRecord(resultRecord);
			}

			//User menu items
			new RenderService().UserMenuItemsManagement(pageModel);

			return null;
		}

		public IActionResult OnPost(BaseErpPageModel pageModel)
		{
			//User menu items
			new RenderService().UserMenuItemsManagement(pageModel);

			return null;
		}

	}
}
