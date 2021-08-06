using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.PluginsProject.Services
{
	public class RenderService : BaseService
	{
		public void UserMenuItemsManagement(BaseErpPageModel pageModel)
		{
			if (pageModel.AppName == "projects")
			{
				var createTask = new MenuItem()
				{
					IsHtml = true,
					Content = "<div class='menu-nav-wrapper'><div class='menu-nav'><a href='/projects/tasks/tasks/c/create'><i class='fa fa-plus'></i> Create Task</a></div></div>",
					isDropdownRight = false,
					RenderWrapper = false,
					SortOrder = 1
				};
				pageModel.AddUserMenu(createTask);
			}
		}
	}
}
