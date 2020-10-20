using System;
using System.Collections.Generic;

namespace SalesSystem.BLL.DefinitionObjects.Products.Interfaces
{
    public interface Iproduct
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string CategoryName { get; set; }
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int cost { get; set; }
        public int CreatedById { get; set; }
        public List<IParts> lstParts { get; set; }
        void CalculateCost();
    }
}
