using Microsoft.AspNetCore.Mvc;

namespace Spice_Wise.Controllers.ViewControllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
