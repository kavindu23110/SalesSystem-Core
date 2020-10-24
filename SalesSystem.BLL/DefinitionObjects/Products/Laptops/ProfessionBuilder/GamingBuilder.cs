using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using System;

namespace SalesSystem.BLL.DefinitionObjects.Products.Laptops.ProfessionBuilder
{
    public class GamingBuilder : AbstractBuilder, IProfessionBuilder
    {



        public bool CheckQuality()
        {
            throw new NotImplementedException();
        }

        public Iproduct GetLaptop()
        {
            return product;
        }



    }
}
