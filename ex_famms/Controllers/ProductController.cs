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
        [ResponseCache(Duration =10)]
        public IActionResult Index()
        {

            var product = _context.Products.ToList();

            var model = new ProductIndexVM
            {
                Products = product,
                
            };
            return View(model);
        }
    }
}
