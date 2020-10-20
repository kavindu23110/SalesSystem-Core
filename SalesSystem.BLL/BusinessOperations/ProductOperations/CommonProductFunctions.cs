using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using SalesSystem.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.BLL.BusinessOperations.ProductOperations
{
   public static class CommonProductFunctions
    {
        public static void  SetProductDetailsFromDTO(ref DTO_Product dTO, ref Iproduct product)
        {
            DataRetrivalOperations.ProductdataRetrival data = new DataRetrivalOperations.ProductdataRetrival();
            product.Warrenty = dTO.warrenty;
            product.CategoryName = dTO.ProductCategory;
            product.CategoryId = data.GetCategoryId(dTO.ProductCategory);
            product.BrandId = data.GetBrandId(dTO.BrandName);
            product.Type = dTO.ProductType;
            product.profitMargin = dTO.ProfitMargin;

          

        }

    }
}
