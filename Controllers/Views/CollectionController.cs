using Microsoft.AspNetCore.Mvc;

namespace Spice_Wise.Controllers.ViewControllers
{
    public class CollectionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
