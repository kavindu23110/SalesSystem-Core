using Microsoft.EntityFrameworkCore;
using System;

namespace SalesSystem.BLL.DefinitionObjects.Promotion.EventListner
{
    public class EmailEventListner : IEventListner
    {
        [Obsolete]
        public void RecievePromotions(IPromotion promotion)
        {
            SalesSystem.DAL.SalessystemContext context = new DBContextFactory.SalesDbContextFactory().CreateDbContext();
            context.Database.ExecuteSqlCommand($"exec SP_SendPromotionEmails {promotion.StartDate}, {promotion.EndDate}" +
                $",{promotion.DiscountPercentage},{promotion.description},{promotion.ModelId},{promotion.DealerId}");
        }
    }
}
