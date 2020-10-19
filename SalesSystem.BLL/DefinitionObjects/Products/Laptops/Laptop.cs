using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;

namespace SalesSystem.BLL.DefinitionObjects.Products.Laptops
{
    public class Laptop : Product
    {
        public IParts Battery { get; set; }
    }
}
