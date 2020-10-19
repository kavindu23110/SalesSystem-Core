using System;

namespace SalesSystem.BLL.DefinitionObjects.Products.Interfaces
{
    public interface IProductFactory
    {
        Iproduct CreateProduct(String Productname, string Brand);
        Iproduct CreateMobile(String Productname, string Brand);
    }
}
