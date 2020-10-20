using SalesSystem.BLL.BusinessOperations.ProductOperations;
using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using SalesSystem.BLL.DTO;
using System;
using System.Linq;

namespace SalesSystem.BLL.DefinitionObjects.Products.Laptops.ProfessionBuilder
{
    public class ProfessionDirector
    {
        private IProfessionBuilder builder;

        public ProfessionDirector(IProfessionBuilder builder)
        {
            this.builder = builder;
        }

        internal void Make(DTO.DTO_Product dTO_Product)
        {
            builder.SetValues(dTO_Product);
            BuildProduct(dTO_Product);
        }

        private void BuildProduct(DTO_Product dTO_Product)
        {
            BuildBasicFeatures(dTO_Product);
            if (dTO_Product.CustomizationType=="Gaming")
            {
                builder.AddHeadset();
            }
            builder.SetDetails();
        }

        private void BuildBasicFeatures(DTO.DTO_Product dTO_Product)
        {
            if (dTO_Product.lstparts.Where(p=>p.Name==BOD.ProductAccesorries.Ram).Any())
            {
                builder.AddRam();
            }
            if (dTO_Product.lstparts.Where(p => p.Name == BOD.ProductAccesorries.HDD).Any())
            {
                builder.AddHdd();
            }

            if (dTO_Product.lstparts.Where(p => p.Name == BOD.ProductAccesorries.Screen).Any())
            {
                builder.AddScreen();
            }
        }
    }
}
