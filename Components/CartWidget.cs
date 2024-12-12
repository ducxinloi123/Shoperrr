using Microsoft.AspNetCore.Mvc;
using Shopper.Data;
using Shopper.Infrastructure;
using Shopper.Models;

namespace Shopper.Components
{
    public class CartWidget :ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View(HttpContext.Session.GetJson<Cart>("cart"));
        }


    }
}
