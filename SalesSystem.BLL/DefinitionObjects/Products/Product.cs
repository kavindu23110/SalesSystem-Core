using SalesSystem.BLL.DBContextFactory;
using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using SalesSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesSystem.BLL.DefinitionObjects.Products
{
    public abstract class Product : Iproduct
    {

        public string Name { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string CategoryName { get; set; }
        public  int Id{ get; set; }
        public int cost { get; set; }
        public int BrandId { get; set; }



        public List<IParts> lstParts { get; set; }
        public int CreatedById { get; set; }
        public string Warrenty { get; set; }
        public int CategoryId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public float profitMargin { get; set; }

        public void CalculateCost()
        {
            cost = lstParts.Sum(p => p.cost);
        }


    }
}
