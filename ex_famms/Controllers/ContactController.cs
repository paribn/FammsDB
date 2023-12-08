using ex_famms.Data;
using ex_famms.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ex_famms.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext dbContext)
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
