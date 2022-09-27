using Microsoft.AspNetCore.Mvc;

namespace SaleWebMVC.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
