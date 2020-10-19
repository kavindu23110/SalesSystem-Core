﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesSystem.DAL
{
    public partial class Productdetail
    {
        public Productdetail()
        {
            ProductAccesories = new HashSet<ProductAccesory>();
            Products = new HashSet<Product>();
        }

        [Key]
        public int Id { get; set; }
        public int ProductCategoryId { get; set; }

        [ForeignKey(nameof(ProductCategoryId))]
        [InverseProperty("Productdetails")]
        public virtual ProductCategory ProductCategory { get; set; }
        [InverseProperty(nameof(ProductAccesory.ProductDetails))]
        public virtual ICollection<ProductAccesory> ProductAccesories { get; set; }
        [InverseProperty(nameof(Product.ProductDetails))]
        public virtual ICollection<Product> Products { get; set; }
    }
}