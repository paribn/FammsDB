using ex_famms.Data;
using ex_famms.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ex_famms.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        public IActionResult Index()
        {
            var contact = _context.Contact.ToList();

            var model = new ProductIndexVM
            {
                ContactFooter = contact,

            };
            return View(model);
        }
    }
}
