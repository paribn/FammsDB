using ex_famms.Data;
using ex_famms.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ex_famms.Views.Shared.Components.Footer
{
    public class FooterViewComponent :ViewComponent
    {
        private readonly AppDbContext _context;

        public FooterViewComponent(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        public IViewComponentResult Invoke()
        {
            var footerContact = _context.Footers.ToList();

            var model = new FooterVM
            {
                Footers = footerContact,

            };

            return View(model);
        }
    }

}
