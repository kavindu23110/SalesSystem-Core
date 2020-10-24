using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SalesSystem.Attributes;
using SalesSystem.BLL.DefinitionObjects;
using SalesSystem.BLL.DTO;
using SalesSystem.BLL.Interfaces;
using SalesSystem.Helpers;
using SalesSystem.Models;

namespace SalesSystem.Controllers
{
    [AccessAuthorizationAll]
    public class ProductController : Controller
    {
        private readonly IMapper _mapper;


        //Get Services From DI
        public ProductController(IMapper mapper, IDataRetrival dataRetrival)
        {
            _mapper = mapper;

        }

        public IActionResult Index()
        {
            ProductViewModel productViewModel = new ProductViewModel();
            new ProductViewModelDataFill().FillProductViewModel(ref productViewModel);
            return View(productViewModel);
        }


        public IActionResult AddNewProduct(ProductViewModel productViewModel)
        {
            var user = new DTO_User();
            if (ModelState.IsValid)
            {
                int id = 0;
                var ProductDto = new DTO_Product();
                _mapper.Map(productViewModel, ProductDto);
                var result = new Dealer(user).SaveProduct(ProductDto);
                if (result)
                {

                    TempData[BLL.BOD.CommonValues.Success] = true;
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData[BLL.BOD.CommonValues.UnSuccess] = true;
                }

            }
            new ProductViewModelDataFill().FillProductViewModel(ref productViewModel);
            return View("Index", productViewModel);
        }




    }
}
