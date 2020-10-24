using SalesSystem.BLL.DTO;
using System;
using System.Collections.Generic;

namespace SalesSystem.BLL.DefinitionObjects.Promotion
{
    public interface IPromotion
    {
        public List<DAL.NotificationTypes> Eventlistners{ get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float DiscountPercentage { get; set; }
        public string description { get; set; }
        public int ModelId { get; set; }
        public int DealerId { get; set; }
        void SetInformation(DTO_Promotion dTO_Promotion, DAL.SalessystemContext context);
    }
}
