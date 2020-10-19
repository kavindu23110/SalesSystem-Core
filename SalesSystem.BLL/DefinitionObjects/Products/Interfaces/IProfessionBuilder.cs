namespace SalesSystem.BLL.DefinitionObjects.Products.Interfaces
{
    public interface IProfessionBuilder
    {
        void AddHdd();
        void AddRam();
        Iproduct GetLaptop();
        bool CheckQuality();

    }
}
