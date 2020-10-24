using SalesSystem.BLL.DefinitionObjects.Promotion.EventListner;
using System.Collections.Generic;

namespace SalesSystem.BLL.DefinitionObjects.Promotion
{
    public class NotificationHandler
    {
        private IPromotion Promotion;

        public NotificationHandler(IPromotion promotion)
        {
            lsteventListners = new List<IEventListner>();
            Promotion = promotion;
            AddEventSubscribers();
        }

        private void AddEventSubscribers()
        {
            var eventListner = new EventListnerFactory();
            foreach (var item in Promotion.Eventlistners)
            {
                lsteventListners.Add(eventListner.GetEventListner(item.Name));
            }
        }

        public List<IEventListner> lsteventListners { get; set; }
        private void Subscribe(IEventListner eventListner)
        {
            lsteventListners.Add(eventListner);
        }

        private void UnSubscribe(IEventListner eventListner)
        {
            lsteventListners.Remove(eventListner);
        }

        public void NotifySubsceribers()
        {
            foreach (var item in lsteventListners)
            {
                item.RecievePromotions(Promotion);
            }
        }


    }


}
