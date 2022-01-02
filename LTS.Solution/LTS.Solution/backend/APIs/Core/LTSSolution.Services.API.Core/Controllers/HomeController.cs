using Microsoft.AspNetCore.Mvc;

namespace LTSSolution.Services.API.Core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
