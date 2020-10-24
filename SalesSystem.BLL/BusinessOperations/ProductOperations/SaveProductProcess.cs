using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using SalesSystem.BLL.UserOperations;
using SalesSystem.DAL;
using System;
using System.Collections.Generic;

namespace SalesSystem.BLL.BusinessOperations.ProductOperations
{
    public class SaveProductProcess : OperationsBase
    {
        internal bool Execute(Iproduct product)
        {
            var productobj = CreateProductDBObject(product);
            var productdetailsobj = CreateProductDetailsDBObject(product);
            var lstAccessoriesobj = CreateAccessoryListDBObjects(product.lstParts);
            try
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    context.Productdetails.Add(productdetailsobj);
                    context.SaveChanges();
                    productobj.ProductDetailsId = productdetailsobj.Id;
                    context.Product.Add(productobj);
                    context.SaveChanges();
                    lstAccessoriesobj.ForEach(p => p.ProductDetailsId = productobj.ProductDetailsId);
                    context.ProductAccesories.AddRange(lstAccessoriesobj);
                    context.SaveChanges();
                    tran.Commit();
                }
            }
            catch (Exception ex)
            {

                return false;
            }
            return true;
        }

        private List<ProductAccesories> CreateAccessoryListDBObjects(List<IParts> lstParts)
        {
            List<ProductAccesories> lstAccessories = new List<ProductAccesories>();
            foreach (var item in lstParts)
            {
                ProductAccesories accesories = new ProductAccesories();
                accesories.AccesoryId = item.Id;
                lstAccessories.Add(accesories);
            }
            return lstAccessories;
        }

        private Productdetails CreateProductDetailsDBObject(Iproduct product)
        {
            Productdetails productdetails = new Productdetails();
            productdetails.ProductCategoryId = product.CategoryId;
            productdetails.Profitmargin = product.profitMargin;
            productdetails.Warrenty = product.Warrenty;
            productdetails.Details = product.Details;
            return productdetails;
        }

        private Product CreateProductDBObject(Iproduct product)
        {
            Product obj = new Product();
            obj.BrandId = product.BrandId;
            obj.ModelName = product.Model;
            return obj;
        }
    }
}
