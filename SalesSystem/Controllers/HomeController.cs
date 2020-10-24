using Microsoft.AspNetCore.Mvc;

namespace SalesSystem.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
