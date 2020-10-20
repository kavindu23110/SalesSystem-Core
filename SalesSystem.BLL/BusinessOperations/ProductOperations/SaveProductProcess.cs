using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using SalesSystem.BLL.UserOperations;
using SalesSystem.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.BLL.BusinessOperations.ProductOperations
{
    public class SaveProductProcess : OperationsBase
    {
        internal void Execute(Iproduct product)
        {
            CreateProductDBObject(product);
            foreach (var item in product.lstParts)
            {
                if (item.Id>0)
                {

                }
            }
        }

        private Product CreateProductDBObject(Iproduct product)
        {
            Product obj = new Product();
            obj.BrandId=
        }
    }
}
