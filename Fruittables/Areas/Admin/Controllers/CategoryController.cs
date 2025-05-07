using Microsoft.AspNetCore.Mvc;

namespace Fruittables.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
