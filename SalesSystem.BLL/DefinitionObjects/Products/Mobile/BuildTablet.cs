using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using System;

namespace SalesSystem.BLL.DefinitionObjects.Products.Mobile
{
    public class BuildTablet
    {
        public Iproduct CreateTablet(DTO.DTO_Product dTO_Product)
        {
            MobilePhone mobile = new MobilePhone();
            AddFeatures(mobile);
            SetDetails(mobile,dTO_Product);
            return mobile;
        }

        private void SetDetails(MobilePhone mobile, DTO.DTO_Product dTO_Product)
        {
            mobile. Name = "Tablet";
            mobile. CategoryName = dTO_Product.ProductCategory;
            mobile. Type = dTO_Product.ProductType;
            mobile. Model = dTO_Product.ModelName;
        }

        private void AddFeatures(MobilePhone mobile)
        {
            var data = new DataRetrivalOperations.ProductdataRetrival();
            var display = data.GetParts(BOD.ProductAccesorries.Screen, 6, BOD.Units.Inch);
            mobile.lstParts.Add(display);
        }
    }
}
