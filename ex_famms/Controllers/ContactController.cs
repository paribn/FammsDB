using ex_famms.Data;
using ex_famms.Models;
using ex_famms.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactVM model)
        {
            if (!ModelState.IsValid)return View(model);



            var query = new Query
            {
                FullName = model.FullName,
                Email = model.Email,
                Subject = model.Subject,
                Message = model.Message
            };

            _context.Query.Add(query);
            _context.SaveChanges();
            
           
            return RedirectToAction("Index");
        }


    }
}
