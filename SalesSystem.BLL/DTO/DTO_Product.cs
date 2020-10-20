using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.BLL.DTO
{
 public   class DTO_Product
    {

        public string SupplierName { get; set; }
        public string ProductCategory { get; set; }
        public string ModelName { get; set; }
        public string ProductType { get; set; }
        public string CustomizationType { get; set; }
        public string BrandName { get; set; }
        public string warrenty { get; set; }
        public string Details { get; set; }
        public float ProfitMargin { get; set; }
        public float Cost { get; set; }
        public List<IParts> lstparts { get; set; }
    }
}
