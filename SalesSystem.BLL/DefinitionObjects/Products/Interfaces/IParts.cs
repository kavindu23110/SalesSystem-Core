namespace SalesSystem.BLL.DefinitionObjects.Products.Interfaces
{
    public interface IParts
    {
        public int size { get; set; }
        public string Unit { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public int cost { get; set; }
        public int ProductCategoryId { get; set; }
    }
}
