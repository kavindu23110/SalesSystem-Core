﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace SalesSystem.DAL
{
    public partial class Product
    {
        public Product()
        {
            StockProduct = new HashSet<StockProduct>();
        }

        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ProductDetailsId { get; set; }
        public string ModelName { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Productdetails ProductDetails { get; set; }
        public virtual ICollection<StockProduct> StockProduct { get; set; }
    }
}