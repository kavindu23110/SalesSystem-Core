using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SalesSystem.SOAP.Models

{
    [DataContract]
    public class PromotionViewModel
    {
   
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }
        [DataMember]
        public float DiscountPercentage { get; set; }
        [DataMember]
        public List<string> lstDealers { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public string DealerName { get; set; }
        [DataMember]
        public string Promotion { get; set; }

    }
}
