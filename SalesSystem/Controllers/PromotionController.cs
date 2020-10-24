using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SalesSystem.Attributes;
using SalesSystem.BLL.DataRetrivalOperations;
using SalesSystem.BLL.DefinitionObjects;
using SalesSystem.BLL.DTO;
using SalesSystem.Helpers;
using SalesSystem.Models;

namespace SalesSystem.Controllers
{
    [AccessAuthorizationSupplierOnly]
    public class PromotionController : Controller
    {
        private readonly IMapper _mapper;
        
        public PromotionController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            PromotionViewModel promotionViewModel = new PromotionViewModel();
            new PromotionViewModelDataFill().FillViewModel(ref promotionViewModel);
            return View(promotionViewModel);
        }

        public IActionResult SendPromotion(PromotionViewModel promotionViewModel)
        {
            if (ModelState.IsValid)
            {
                var DTO = new DTO_Promotion();
                _mapper.Map(promotionViewModel, DTO);
                var result=new Dealer(new DTO_User()).SendNotification(DTO);
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
            new PromotionViewModelDataFill().FillViewModel(ref promotionViewModel);
            return View("index",promotionViewModel);
        }


    }
}
