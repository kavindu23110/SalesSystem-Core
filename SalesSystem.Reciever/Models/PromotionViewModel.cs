using System;
using System.Collections.Generic;

namespace SalesSystem.API.Models
{
    public class PromotionViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float DiscountPercentage { get; set; }
        public List<string> lstDealers { get; set; }
        public string description { get; set; }
        public string Model { get; set; }
        public string DealerName { get; set; }
        public string Promotion { get; set; }

    }
}
