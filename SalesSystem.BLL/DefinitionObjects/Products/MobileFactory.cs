using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using System;

namespace SalesSystem.BLL.DefinitionObjects.Products
{
    class MobileFactory : IMobileBuilder
    {
        public Iproduct GetMobile()
        {
            throw new NotImplementedException();
        }

        public Iproduct GetTablet()
        {
            throw new NotImplementedException();
        }
    }
}
