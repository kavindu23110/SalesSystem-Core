using SalesSystem.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesSystem.BLL.DefinitionObjects.Products.Laptops.ProfessionBuilder
{
    public abstract class AbstractBuilder
    {

        protected Laptop product = new Laptop();
        DataRetrivalOperations.ProductdataRetrival data = new DataRetrivalOperations.ProductdataRetrival();
        protected DTO_Product dTO_Product;

        public void AddHdd()
        {

            var UserRequest = dTO_Product.lstparts.Where(p => p.Name == BOD.ProductAccesorries.HDD).FirstOrDefault();

            SetpartsToProduct(UserRequest);
        }

        public void AddHeadset()
        {
            var UserRequest = dTO_Product.lstparts.Where(p => p.Name == BOD.ProductAccesorries.Headset).FirstOrDefault();

            SetpartsToProduct(UserRequest);
        }

        protected void SetpartsToProduct(Interfaces.IParts userRequest)
        {
            var Part = data.GetParts(userRequest.Name, userRequest.size, userRequest.Unit);
            product.lstParts.Add(Part);
        }

        public void AddRam()
        {
            var UserRequest = dTO_Product.lstparts.Where(p => p.Name == BOD.ProductAccesorries.Ram).FirstOrDefault();

            SetpartsToProduct(UserRequest);
        }

        public void AddScreen()
        {
            var UserRequest = dTO_Product.lstparts.Where(p => p.Name == BOD.ProductAccesorries.Screen).FirstOrDefault();

            SetpartsToProduct(UserRequest);
        }

        public void SetValues(DTO_Product dTO_Product)
        {
            this.dTO_Product = dTO_Product;
        }

        public void SetDetails()
        {
            product.Name = dTO_Product.ModelName;
            product.Type = dTO_Product.CustomizationType;
        }
    }
}
