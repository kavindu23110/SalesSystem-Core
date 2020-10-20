using SalesSystem.BLL.BusinessOperations.ProductOperations;
using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using SalesSystem.BLL.DTO;
using System;

namespace SalesSystem.BLL.DefinitionObjects
{
    public class Dealer : User
    {
        public String DealerCode { get; set; }

        public DTO_Product CalculateProduct(DTO_Product dTO_Product)
        {
           Iproduct product= new BuildProduct().Execute(dTO_Product);
           product.CalculateCost();
            dTO_Product.Cost = product.cost;
            return dTO_Product;

        }

        public void SaveProduct(DTO_Product dTO_Product, int id)
        {
            this.Id = id;
            Iproduct product = new BuildProduct().Execute(dTO_Product);
            product.CalculateCost();
            product.CreatedById = this.Id;
            new SaveProductProcess().Execute(product);


        }
    }
}
