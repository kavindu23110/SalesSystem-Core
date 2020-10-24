using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SalesSystem.API.Models;
using SalesSystem.Helpers;

namespace SalesSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private IMessagePublisher message;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(IMessagePublisher messagePublisher)
        {
            message = messagePublisher;
            
        }

        [HttpGet]
        public void Gets()
        {
            DetailsModel detailsModel = new PromotionDataFill().FillDetailsTemplate();
            message.PublisheAsync<DetailsModel>(detailsModel);
        }

    }
}
