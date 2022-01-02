using Microsoft.AspNetCore.Mvc;

namespace LTSSolution.Services.API.Core.Controllers
{
    public class ManageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
