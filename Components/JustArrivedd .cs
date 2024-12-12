using Microsoft.AspNetCore.Mvc;
using Shopper.Data;

namespace Shopper.Components
{
    public class JustArrivedd : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public JustArrivedd(ApplicationDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View(_context.Products.Where(p=>p.IsArrived==true).ToList()); 
        }
    }
}
