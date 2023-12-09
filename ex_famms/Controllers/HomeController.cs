using ex_famms.Data;
using ex_famms.Models;
using ex_famms.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ex_famms.Controllers
{
	public class HomeController : Controller
	{
        private readonly AppDbContext _context;

        public HomeController(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        [ResponseCache(Duration = 10)]
        public IActionResult Index()
        {

            var product = _context.Products.ToList();
            var testimonial = _context.Testimonial.ToList();

            var model = new HomeIndexVM
            {
                Products = product,
                Testimonials = testimonial,
            };
            return View(model);

        }
        

    }
}