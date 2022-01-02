using Microsoft.AspNetCore.Mvc;

namespace LTSSolution.Services.API.Core.Controllers
{
    public class HomeAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
