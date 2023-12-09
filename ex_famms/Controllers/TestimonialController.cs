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

            var model = new HomeIndexVM
            {
                Testimonials = testimonials,

            };
            return View(model);
        }
       
    }
}
