namespace SalesSystem.BLL.DefinitionObjects.Promotion.EventListner
{
    public interface IEventListner
    {
        void RecievePromotions(IPromotion promotion);
    }
}
