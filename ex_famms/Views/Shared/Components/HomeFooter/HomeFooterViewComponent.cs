using ex_famms.Data;
using ex_famms.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ex_famms.Views.Shared.Components.HomeFooter
{
    public class HomeFooterViewComponent :ViewComponent
    {
        private readonly AppDbContext _context;

        public HomeFooterViewComponent(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        public IViewComponentResult Invoke()
        {
            var footerHomeContact = _context.Footers.ToList();

            var model = new FooterVM
            {
                Footers = footerHomeContact,

            };

            return View(model);
        }
    }
}
