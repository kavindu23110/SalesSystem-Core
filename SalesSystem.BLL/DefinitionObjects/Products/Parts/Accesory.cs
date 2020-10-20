using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.BLL.DefinitionObjects.Products.Parts
{
    public class Accesory : IParts
    {
        public int size { get => size; set => size=value; }
        public string Unit { get => Unit; set => Unit = value; }
        public string Name { get =>Name; set => Name= value; }
        public int Id { get => Id; set => Id = value; }
        public int ProductCategoryId { get => ProductCategoryId; set => ProductCategoryId = value; }
    }
}
