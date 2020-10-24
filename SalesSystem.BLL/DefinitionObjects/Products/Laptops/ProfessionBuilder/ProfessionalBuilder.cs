using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using System;

namespace SalesSystem.BLL.DefinitionObjects.Products.Laptops.ProfessionBuilder
{
    public class ProfessionalBuilder : AbstractBuilder, IProfessionBuilder
    {
        Iproduct product = new Laptop();

        public void AddSpecificFeatures()
        {
            throw new NotImplementedException();
        }

        public bool CheckQuality()
        {
            throw new NotImplementedException();
        }

        public Iproduct GetLaptop()
        {
            return product;
        }

        public void SetDetails()
        {
            throw new NotImplementedException();
        }


    }
}
