using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using SalesSystem.BLL.DefinitionObjects.Products.Mobile;
using SalesSystem.BLL.DTO;

namespace SalesSystem.BLL.DefinitionObjects.Products
{
    class MobileFactory : IMobileBuilder
    {
        public Iproduct GetMobile(DTO_Product dTO_Product)
        {
            Iproduct product = null;
            switch (dTO_Product.ProductType)
            {
                case "Tablet":
                    product = GetTablet(dTO_Product);
                    break;
                case "MobilePhone":
                    product = GetMobilePhone(dTO_Product);
                    break;
            }
            return product;
        }

        public Iproduct GetMobilePhone(DTO_Product dTO_Product)
        {
            return new BuildMobilePhone().CreateMobilePhone(dTO_Product);
        }

        public Iproduct GetTablet(DTO_Product dTO_Product)
        {
            return new BuildTablet().CreateTablet(dTO_Product);
        }
    }
}
