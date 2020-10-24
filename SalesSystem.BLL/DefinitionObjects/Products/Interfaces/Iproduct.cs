using System;
using System.Collections.Generic;

namespace SalesSystem.BLL.DefinitionObjects.Products.Interfaces
{
    public interface Iproduct
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string Warrenty { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int cost { get; set; }
        public string CreatedBy { get; set; }
        public string Details{ get; set; }
        public DateTime CreatedOn { get; set; }
        public float profitMargin { get; set; }
        public List<IParts> lstParts { get; set; }
        void CalculateCost();
    }
}
