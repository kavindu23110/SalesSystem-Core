using AutoMapper;
using SalesSystem.BLL.DefinitionObjects;
using SalesSystem.BLL.DTO;
using SalesSystem.SOAP.Models;

namespace SalesSystem.SOAP.Services
{
    public class PromotionService : IPromotionService
    {
        private IMessagePublisher _messagePublisher;
        private readonly IMapper _mapper;

        public PromotionService(IMapper mapper, IMessagePublisher messagePublisher)
        {
            _messagePublisher = messagePublisher;
            _mapper = mapper;
        }
        public bool SendPromotion(PromotionViewModel model)
        {
            var DTO = new DTO_Promotion();
            _mapper.Map(model, DTO);
            var result = new Dealer(new DTO_User()).SendNotification(DTO);
            _messagePublisher.PublisheAsync<bool>(result);
            return result;
        }

    }

}
