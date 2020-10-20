using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.BLL.DefinitionObjects.Products.Parts
{
    public class Accesory : IParts
    {
        public int size { get; set; }
        public string Unit { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public int ProductCategoryId { get; set; }
        public int cost { get; set; }
    }
}
