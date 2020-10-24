using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using SalesSystem.BLL.DefinitionObjects.Products.Laptops;
using SalesSystem.BLL.DTO;

namespace SalesSystem.BLL.DefinitionObjects.Products
{
    class ProductFactory : IProductFactory
    {
        private DTO_Product dTO_Product;

        public Iproduct CreateLaptop(DTO_Product dTO_Product)
        {
            return new LaptopFactory().Getlaptop(dTO_Product);
        }

        public Iproduct CreateMobile(DTO_Product dTO_Product)
        {
            return new MobileFactory().GetMobile(dTO_Product);
        }

        public Iproduct GetProduct(DTO_Product dTO_Product)
        {
            Iproduct product = null;
            switch (dTO_Product.ProductCategory)
            {
                case "Mobile":
                    product = CreateMobile(dTO_Product);
                    break;
                case "Laptop":
                    product = CreateLaptop(dTO_Product);
                    break;
            }
            return product;

        }




    }
}
