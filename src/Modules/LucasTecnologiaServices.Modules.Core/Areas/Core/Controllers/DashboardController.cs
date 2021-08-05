using LucasTecnologiaServices.Infrastructure.Data;
using LucasTecnologiaServices.Infrastructure.Web.SmartTable;
using LucasTecnologiaServices.Modules.Core.Areas.Core.ViewModels;
using LucasTecnologiaServices.Modules.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LucasTecnologiaServices.Modules.Core.Areas.Core.Controllers
{
    [Area("Core")]
    [Authorize(Roles = "admin, vendor")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class DashboardController : Controller
    {
        [Route("admin/dashboard-tpl")]
        public IActionResult HomeTemplate()
        {
            return View();
        }
    }
}
