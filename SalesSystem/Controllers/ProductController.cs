using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SalesSystem.BLL.DefinitionObjects;
using SalesSystem.BLL.DTO;
using SalesSystem.BLL.Interfaces;
using SalesSystem.Helpers;
using SalesSystem.Models;

namespace SalesSystem.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ViewModelDataFill datafill;
        //Get Services From DI
        public ProductController(IMapper mapper, IDataRetrival dataRetrival)
        {
            _mapper = mapper;
            datafill = new ViewModelDataFill(dataRetrival);
        }

        public IActionResult Index()
        {
            ProductViewModel productViewModel = new ProductViewModel();
            return View(productViewModel);
        }


        public IActionResult AddNewProduct(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                int id = 0
                var ProductDto = new DTO_Product();
                _mapper.Map(productViewModel, ProductDto);

                new Dealer().SaveProduct(ProductDto, id);
            }
            return View(productViewModel);
        }

        


        public IActionResult CalculateProduct(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var ProductDto = new DTO_Product();
                _mapper.Map(productViewModel, ProductDto);
                var result=new Dealer().CalculateProduct(ProductDto);
                _mapper.Map(result, productViewModel);
            }
            return View(productViewModel);
        }
    }
}
