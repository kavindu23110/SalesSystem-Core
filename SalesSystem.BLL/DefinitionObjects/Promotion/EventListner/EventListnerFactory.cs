using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.BLL.DefinitionObjects.Promotion.EventListner
{
    class EventListnerFactory
    {
        public IEventListner GetEventListner(string PromotionType)
        {
            switch (PromotionType)
            {
                case BOD.NotificationTypes.Email:
                    return new EmailEventListner();
            
                default:
                    return null;

            }
        }
    }
}
