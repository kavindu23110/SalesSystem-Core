using Microsoft.AspNetCore.Mvc;

namespace SalesSystem.Controllers
{
    public class StockController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
