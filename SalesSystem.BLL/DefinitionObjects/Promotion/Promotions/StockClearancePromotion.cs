using SalesSystem.BLL.DTO;
using SalesSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesSystem.BLL.DefinitionObjects.Promotion
{
    public class StockClearencen : IPromotion
    {
        public DAL.Promotion Promotion { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float DiscountPercentage { get; set; }
        public string description { get; set; }
        public int ModelId { get; set; }
        public int DealerId { get; set; }

        public List<NotificationTypes> Eventlistners { get; set; }



        public void SetInformation(DTO_Promotion dTO_Promotion, SalessystemContext context)
        {
            Promotion = context.Promotion.Where(P => P.Name == dTO_Promotion.Promotion).FirstOrDefault();
            DiscountPercentage = dTO_Promotion.DiscountPercentage;
            StartDate = dTO_Promotion.StartDate;
            EndDate = dTO_Promotion.EndDate;
            description = dTO_Promotion.description;
            ModelId = context.Product.Where(P => P.ModelName == dTO_Promotion.Model).Select(P => P.Id).FirstOrDefault();
            DealerId = context.User.Where(P => P.UserName == dTO_Promotion.DealerName).FirstOrDefault().Id;
            Eventlistners = context.PromotionEventlistner.Where(p => p.PromotionId == Promotion.Id).Select(p => p.EventListner).ToList();
        }
    }
}
