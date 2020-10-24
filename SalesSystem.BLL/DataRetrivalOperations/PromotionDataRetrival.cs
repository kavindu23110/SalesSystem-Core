using Microsoft.EntityFrameworkCore;
using SalesSystem.BLL.DBContextFactory;
using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using SalesSystem.BLL.DefinitionObjects.Products.Parts;
using SalesSystem.BLL.Interfaces;
using SalesSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesSystem.BLL.DataRetrivalOperations
{
    public class PromotionDataRetrival : IDataRetrival
    {
        private readonly SalessystemContext context;

        public PromotionDataRetrival()
        {
            context = new SalesDbContextFactory().CreateDbContext();
        }

        public List<string> GetDealers()
        {
            return context.User.Where(p => p.Role.RoleName == "Dealer").Select(p => p.UserName).ToList();
        }

        public List<string> GetPromotiontypes()
        {
            return context.Promotion.Select(p => p.Name).ToList();
        }

        public List<string> GetProductModels()
        {
            return context.Product.Select(p => p.ModelName).ToList();
        }

        public List<string> GetProductCategory()
        {
            return context.ProductCategory.Select(p => p.CategoryName).ToList();
        }

        public List<string> GetBrands()
        {
            return context.Brand.Select(p => p.BrandName ).ToList();
        }

        public List<string> GetSuppliers()
        {
            return context.User.Where(p => p.Role.RoleName == "Supplier").Select(p => p.UserName).ToList();
        }

        internal int GetCategoryId(string CategoryName)
        {
            return context.ProductCategory.Where(p => p.CategoryName == CategoryName).FirstOrDefault().Id;
        }

        public int GetBrandId(string Brandname)
        {
          return  context.Brand.Where(p => p.BrandName == Brandname).FirstOrDefault().Id;
        }
    }
}
