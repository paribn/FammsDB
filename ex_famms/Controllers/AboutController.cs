using ex_famms.Data;
using ex_famms.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ex_famms.Controllers
{
    public class AboutController : Controller
    {
        
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
