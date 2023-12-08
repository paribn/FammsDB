using ex_famms.Data;
using ex_famms.ViewModels;
using Microsoft.AspNetCore.Mvc;
using ex_famms.ViewModels;

namespace ex_famms.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        public IActionResult Index()
        {

            var product = _context.Products.ToList();
            var contact =_context.Contact.ToList();

            var model = new ProductIndexVM
            {
                Products = product,
                ContactFooter = contact,
                
            };
            return View(model);
        }
    }
}
