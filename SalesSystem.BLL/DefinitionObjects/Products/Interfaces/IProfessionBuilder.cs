using SalesSystem.BLL.DTO;

namespace SalesSystem.BLL.DefinitionObjects.Products.Interfaces
{
    public interface IProfessionBuilder
    {
        void SetValues(DTO_Product dTO_Product);
        void AddHdd();
        void AddRam();
        void AddScreen();
        void SetDetails();
   
        void AddHeadset();
        Iproduct GetLaptop();
        bool CheckQuality();
    

    }
}
