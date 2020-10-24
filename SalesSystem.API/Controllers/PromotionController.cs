using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SalesSystem.API.Models;
using SalesSystem.BLL.DefinitionObjects;
using SalesSystem.BLL.DTO;
using SalesSystem.Helpers;

namespace SalesSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {
        private readonly IMapper _mapper;

        public PromotionController(IMapper mapper)
        {
            _mapper = mapper;
        }
        [HttpGet]
        public DetailsModel Gets()
        {
            DetailsModel detailsModel = new PromotionDataFill().FillDetailsTemplate();
            return detailsModel;
        }

        public IActionResult SendPromortion(PromotionViewModel promotion)
        {
            if (ModelState.IsValid)
            {
                var DTO = new DTO_Promotion();
                _mapper.Map(promotion, DTO);
                var result = new Dealer(new DTO_User()).SendNotification(DTO);
                if (result)
                {
                    return Ok(200);
                }
                return BadRequest(new { message = "Error Occured Processing your Request.Please retry later." });
            }
            return BadRequest(new { message = "Please fill the values properly" });
        }
    }
}
