using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using SalesSystem.BLL.DTO;

namespace SalesSystem.BLL.DefinitionObjects.Products.Mobile
{
    class BuildMobilePhone
    {
        internal Iproduct CreateMobilePhone(DTO_Product dTO_Product)
        {
            Iproduct mobile = new MobilePhone();
            AddFeatures(mobile);
            SetDetails(mobile, dTO_Product);
            return mobile;

        }

        private void AddFeatures(Iproduct mobile)
        {
            var data = new DataRetrivalOperations.ProductdataRetrival();
            var display = data.GetParts(BOD.ProductAccesorries.Screen, 4, BOD.Units.Inch);
            var Ram = data.GetParts(BOD.ProductAccesorries.Ram, 6, BOD.Units.GB);
            mobile.lstParts.Add(display);
            mobile.lstParts.Add(Ram);
        }

        private void SetDetails(Iproduct mobile, DTO_Product dTO_Product)
        {
            mobile.Name = "MobilePhone";
            mobile.CategoryName = dTO_Product.ProductCategory;
            mobile.Type = dTO_Product.ProductType;
            mobile.Model = dTO_Product.ModelName;
        }



    }
}
