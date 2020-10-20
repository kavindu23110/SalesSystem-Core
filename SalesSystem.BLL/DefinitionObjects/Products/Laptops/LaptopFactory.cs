using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using SalesSystem.BLL.DefinitionObjects.Products.Laptops.ProfessionBuilder;
using SalesSystem.BLL.DTO;
using System;

namespace SalesSystem.BLL.DefinitionObjects.Products.Laptops
{
    public class LaptopFactory
    {
        //public Iproduct GetLaptop(string laptopName)
        //{

        //}
        internal Iproduct Getlaptop(DTO_Product dTO_Product)
        {
            Iproduct laptop=null;
            switch (dTO_Product.ProductType)
            {
                case "Basic":
                    laptop=GetBasiclaptop(dTO_Product);
                    break;   
                case "Customized":
                    laptop=GetCustomizedlaptop(dTO_Product);
                    break;
            
            }
            return laptop;
        }

        private Iproduct GetCustomizedlaptop(DTO_Product dTO_Product)
        {
            IProfessionBuilder builder = null;
            switch (dTO_Product.CustomizationType)
            {
                case "Professional":
                    builder = new ProfessionalBuilder();
                    break;
                case "Gaming":
                     builder = new GamingBuilder();
                    break;
           
            }
            var Director = new ProfessionDirector(builder);
            Director.Make(dTO_Product);
            return builder.GetLaptop();
        }

        private Iproduct GetBasiclaptop(DTO_Product dTO_Product)
        {
            Iproduct laptop = null;/*new BasicLaptop(dTO_Product);*/
            return laptop;
        }
    }
}
