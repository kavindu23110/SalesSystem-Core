using SalesSystem.BLL.DTO;

namespace SalesSystem.BLL.DefinitionObjects.Products.Interfaces
{
    public interface IProductFactory
    {
        Iproduct CreateLaptop(DTO_Product dTO_Product);
        Iproduct CreateMobile(DTO_Product dTO_Product);
    }
}
