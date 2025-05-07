using Microsoft.AspNetCore.Mvc;

namespace Fruittables.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
