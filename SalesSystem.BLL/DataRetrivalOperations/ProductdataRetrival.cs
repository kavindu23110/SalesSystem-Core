﻿using SalesSystem.BLL.DBContextFactory;
using SalesSystem.BLL.DefinitionObjects.Products.Interfaces;
using SalesSystem.BLL.DefinitionObjects.Products.Parts;
using SalesSystem.BLL.Interfaces;
using SalesSystem.DAL;
using System.Collections.Generic;
using System.Linq;

namespace SalesSystem.BLL.DataRetrivalOperations
{
    public class ProductdataRetrival : IDataRetrival
    {
        private readonly SalessystemContext context;


        public ProductdataRetrival()
        {
            context = new SalesDbContextFactory().CreateDbContext();
        }

        public IParts GetParts(string name, int size, string units)
        {
            IParts CreatedPart = null;
            var accesorry = context.Accesories.Where(p => p.AccesoryName == name && p.Size == size && p.SizeUnits == units).FirstOrDefault();

            if (accesorry != null)
            {
                Accesory part = new Accesory()
                {
                    Id = accesorry.Id,
                    ProductCategoryId = accesorry.ProductCategoryId,
                    Name = accesorry.AccesoryName,
                    size = accesorry.Size,
                    Unit = accesorry.SizeUnits
                };
                CreatedPart = part;
            }
            else
            {
                Accesory part = new Accesory()
                {
                    Id = 0,
                    ProductCategoryId = 0,
                    Name = accesorry.AccesoryName,
                    size = accesorry.Size,
                    Unit = accesorry.SizeUnits
                };
                CreatedPart = part;
            }

            return CreatedPart;
        }

        public List<string> GetProductCategory()
        {
            return context.ProductCategory.Select(p => p.CategoryName).ToList();
        }

        public List<string> GetBrands()
        {
            return context.Brand.Select(p => p.BrandName).ToList();
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
            return context.Brand.Where(p => p.BrandName == Brandname).FirstOrDefault().Id;
        }
    }
}
