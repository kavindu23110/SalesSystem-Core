﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesSystem.DAL
{
    public partial class Accesory
    {
        public Accesory()
        {
            ProductAccesories = new HashSet<ProductAccesory>();
        }

        [Key]
        public int Id { get; set; }
        public int ProductCategoryId { get; set; }

        [ForeignKey(nameof(ProductCategoryId))]
        [InverseProperty("Accesories")]
        public virtual ProductCategory ProductCategory { get; set; }
        [InverseProperty(nameof(ProductAccesory.Accesory))]
        public virtual ICollection<ProductAccesory> ProductAccesories { get; set; }
    }
}