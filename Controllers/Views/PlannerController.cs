using Microsoft.AspNetCore.Mvc;

namespace Spice_Wise.Controllers.ViewControllers
{
    public class PlannerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
