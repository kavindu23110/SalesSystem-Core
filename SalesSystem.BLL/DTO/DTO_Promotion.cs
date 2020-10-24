using System;

namespace SalesSystem.BLL.DTO
{
    public class DTO_Promotion
    {

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float DiscountPercentage { get; set; }
        public string description { get; set; }
        public string Model { get; set; }
        public string DealerName { get; set; }
        public string Promotion { get; set; }
    }
}
