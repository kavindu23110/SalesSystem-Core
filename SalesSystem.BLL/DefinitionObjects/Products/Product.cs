using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using System;

namespace SalesSystem.BLL.DefinitionObjects.Products
{
    public abstract class Product : Iproduct
    {
        public IParts Ram { get; set; }
        public IParts Battery { get; set; }
        public IParts Display { get; set; }

        public bool CheckPerformnce(string )
        {
            throw new NotImplementedException();
        }
    }
}
