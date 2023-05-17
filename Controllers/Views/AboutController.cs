using Microsoft.AspNetCore.Mvc;

namespace Spice_Wise.Controllers.ViewControllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
