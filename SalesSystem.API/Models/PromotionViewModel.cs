using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.API.Models
{
    public class PromotionViewModel
    {
        public PromotionViewModel()
        {
            lstProducts=new List<string>();
            lstDealers = new List<string>();
            lstPromotions = new List<string>();
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
        }
        public List<string> lstProducts { get; set; }
        public List<string> lstPromotions { get; set; }
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
