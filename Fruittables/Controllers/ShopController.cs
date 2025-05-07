using Fruittables.DAL;
using Fruittables.Models;
using Fruittables.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IActionResult> Detail( int? id)

        {
            if (id is null || id <= 0) return BadRequest();

            Product? product =await _context.Products
                .Include(p => p.ProductImages.OrderByDescending(pi => pi.IsPrimqary != null))
                .Include(p=>p.Category)
              .FirstOrDefaultAsync(p => p.Id == id);

            if (product is null)  return NotFound();

            DetailVM detailVM = new DetailVM
            { 
            Product=product,

            RelatedProducts= await _context.Products
            .Where(p=>p.CategoryId==product.CategoryId && p.Id!=product.Id)
            .Take(4)
            .Include(p=>p.ProductImages.Where(pi=>pi.IsPrimqary!=null))
            .ToListAsync()
            };
            return View(detailVM);
        }

    }
}
