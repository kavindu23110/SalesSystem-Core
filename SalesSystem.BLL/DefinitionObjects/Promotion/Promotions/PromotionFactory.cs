using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.BLL.DefinitionObjects.Promotion.Promotions
{
 public   class PromotionFactory
    {
        public IPromotion getPromotion(string PromotionType)
        {
            switch (PromotionType)
            {
                case BOD.Promotions.YearEndPromotion:
                    return new YearEndPromotion();
                case BOD.Promotions.StockClearence:
                    return new StockClearencen();
                default:
                    return null;
                   
            }
        }
    }
}
