using ex_famms.Data;
using ex_famms.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ex_famms.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly AppDbContext _context;

        public TestimonialController(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        public IActionResult Index()
        {

            var testimonials = _context.Testimonial.ToList();
            var contact = _context.Contact.ToList();

            var model = new ProductIndexVM
            {
                Testimonials = testimonials,
                ContactFooter = contact,

            };
            return View(model);
        }
    }
}
