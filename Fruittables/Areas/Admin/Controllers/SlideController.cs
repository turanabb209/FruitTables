using Microsoft.AspNetCore.Mvc;

namespace Fruittables.Areas.Admin.Controllers
{
    public class SlideController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
