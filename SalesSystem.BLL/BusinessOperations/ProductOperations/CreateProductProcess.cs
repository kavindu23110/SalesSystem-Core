using SalesSystem.BLL.DefinitionObjects.Products;
using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using SalesSystem.BLL.UserOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.BLL.BusinessOperations.ProductOperations
{
  public  class BuildProduct:OperationsBase
    {


        public Iproduct Execute(DTO.DTO_Product dTO_Product)
        {
         return    new ProductFactory().GetProduct(dTO_Product);
        }
    }
}
