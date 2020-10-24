using SalesSystem.BLL.BusinessOperations.ProductOperations;
using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using SalesSystem.BLL.DTO;
using System;

namespace SalesSystem.BLL.DefinitionObjects
{
    public class Dealer : User
    {

        public Dealer(DTO_User dTO_User)
        {
            Username = dTO_User.username;
        }

        public String DealerCode { get; set; }

        public DTO_Product CalculateProduct(DTO_Product dTO_Product)
        {
            Iproduct product = new BuildProduct().Execute(dTO_Product);
            product.CalculateCost();
            dTO_Product.Cost = product.cost;
            return dTO_Product;

        }

        public bool SaveProduct(DTO_Product dTO_Product)
        {

            Iproduct product = new BuildProduct().Execute(dTO_Product);

            product.CreatedOn = DateTime.Now;
            product.CreatedBy = this.Username;
            return new SaveProductProcess().Execute(product);


        }
    }
}
