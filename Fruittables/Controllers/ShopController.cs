using Fruittables.DAL;
using Fruittables.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fruittables.Controllers
{
    public class ShopController : Controller
    {
        public readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()

        {
            return View();
        }

        public IActionResult Detail( int? id)

        {
            if (id is null || id <= 0) return BadRequest();

            Product product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product is null)  return NotFound();

            return View();
        }

    }
}
