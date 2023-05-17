using Microsoft.AspNetCore.Mvc;

namespace Spice_Wise.Controllers.ViewControllers
{
    public class SupportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
