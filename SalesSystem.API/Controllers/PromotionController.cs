using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesSystem.API.Models;
using SalesSystem.Helpers;

namespace SalesSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {
        [HttpGet]
        public DetailsModel Gets()
        {
            DetailsModel detailsModel = new PromotionDataFill().FillDetailsTemplate();
            return detailsModel;
        }
    }
}
