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
        public IActionResult Index()
        {

            var product = _context.Products.ToList();
            var testimonial = _context.Testimonial.ToList();
            var contact = _context.Contact.ToList();    

            var model = new ProductIndexVM
            {
                Products = product,
                Testimonials = testimonial,
                ContactFooter = contact,
            };
            return View(model);

        }
        

    }
}