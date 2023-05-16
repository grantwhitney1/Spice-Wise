using Microsoft.AspNetCore.Mvc;

namespace Spice_Wise.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
