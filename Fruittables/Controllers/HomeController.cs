using Fruittables.DAL;
using Fruittables.Models;
using Fruittables.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fruittables.Controllers
{
    public class HomeController : Controller
    {
        public readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            Product product = new Product();
            Category category = new Category();


            HomeVM homeVM = new HomeVM
            {
                Slides = await _context.Slides
                .OrderBy(s => s.Order)
                .Take(3)
                .TolistAsync() ,

                Products = await _context.Products.Take(3)
                .Include(p => p.ProductImages.Where(pi => pi.IsPrimqary != null))

                .ToListAsync()


            };
            return View(homeVM);
        }

    }
}
