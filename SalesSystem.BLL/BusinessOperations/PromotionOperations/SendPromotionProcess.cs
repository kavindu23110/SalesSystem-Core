using SalesSystem.BLL.DefinitionObjects.Promotion;
using SalesSystem.BLL.DefinitionObjects.Promotion.Promotions;
using SalesSystem.BLL.UserOperations;
using System;


namespace SalesSystem.BLL.BusinessOperations.PromotionOperations
{
    public class SendPromotionProcess : OperationsBase
    {
        public bool Execute(DTO.DTO_Promotion dTO_Promotion)
        {
            try
            {
                IPromotion promotion = new PromotionFactory().getPromotion(dTO_Promotion.Promotion);
                promotion.SetInformation(dTO_Promotion, context);
                var notification = new NotificationHandler(promotion);
                notification.NotifySubsceribers();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
