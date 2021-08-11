using LucasTecnologiaServices.Modules.Erp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Components.ScreenMessageViewComponents
{
    public class ScreenMessageViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // because of https://github.com/aspnet/Mvc/issues/6711 use upper line of code instead of
            ViewBag.ScreenMessage = TempData.Get<ScreenMessage>("ScreenMessage");

            return await Task.FromResult<IViewComponentResult>(View("Default"));
        }
    }
}
