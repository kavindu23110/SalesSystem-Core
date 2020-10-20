using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using SalesSystem.BLL.DTO;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SalesSystem.BLL.DefinitionObjects.Products.Laptops.ProfessionBuilder
{
    public class GamingBuilder : AbstractBuilder,IProfessionBuilder
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
