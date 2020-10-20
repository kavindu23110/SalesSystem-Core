using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using SalesSystem.DAL;
using System;

namespace SalesSystem.BLL.DefinitionObjects.Products.Laptops
{
  public  class BasicLaptop : Product
    {

        public BasicLaptop(DTO.DTO_Product dTO_Product)
        {
            AddAccesories();
            setDetails(dTO_Product);
            setBrandId(dTO_Product);
        }

        private void setDetails(DTO.DTO_Product dTO_Product)
        {
            Name = "Basic";
            CategoryName = dTO_Product.ProductCategory;
            Type = dTO_Product.ProductType;
            Model = dTO_Product.ModelName;
            
        }

        private void AddAccesories()
        {
            var data = new DataRetrivalOperations.ProductdataRetrival();


            var display = data.GetParts(BOD.ProductAccesorries.Screen, 14, BOD.Units.Inch);
            lstParts.Add(display);
        
        }
        public void setBrandId(DTO.DTO_Product dTO_Product)
        {
            var data = new DataRetrivalOperations.ProductdataRetrival();
           BrandId = data.GetBrandId(dTO_Product.BrandName);
        }
 
    }
}
