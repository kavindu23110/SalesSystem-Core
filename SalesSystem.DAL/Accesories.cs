﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace SalesSystem.DAL
{
    public partial class Accesories
    {
        public Accesories()
        {
            ProductAccesories = new HashSet<ProductAccesories>();
        }

        public int Id { get; set; }
        public string AccesoryName { get; set; }
        public int ProductCategoryId { get; set; }
        public string Details { get; set; }
        public int Size { get; set; }
        public string SizeUnits { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<ProductAccesories> ProductAccesories { get; set; }
    }
}