using Microsoft.AspNetCore.Mvc;

namespace Spice_Wise.Controllers.ViewControllers
{
    public class PreferencesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
