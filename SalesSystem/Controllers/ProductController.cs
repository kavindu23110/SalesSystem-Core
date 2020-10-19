using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesSystem.Models;

namespace SalesSystem.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductViewModel productViewModel = new ProductViewModel();
            return View(productViewModel);
        }
    }
}
