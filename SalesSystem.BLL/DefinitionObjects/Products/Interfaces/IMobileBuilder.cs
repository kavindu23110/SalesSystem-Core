using SalesSystem.BLL.DTO;

namespace SalesSystem.BLL.DefinitionObjects.Products.Interfaces
{
    public interface IMobileBuilder
    {
        Iproduct GetMobile(DTO_Product dTO_Product);
        Iproduct GetTablet(DTO_Product dTO_Product);
        public Iproduct GetMobilePhone(DTO_Product dTO_Product);

    }
}
