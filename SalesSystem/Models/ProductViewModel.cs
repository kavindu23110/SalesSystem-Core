using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalesSystem.Models
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            lstProduct = new List<Product>();
            lstSupplier = new List<supplier>();
        }
        [Required]
        public int SupplierId { get; set; }
        [Required]
        public int ProductId { get; set; }
        public int BrandIdId { get; set; }
        [Required]
        public int warrenty { get; set; }
        public string Details { get; set; }
        [Required]
        public float ProfitMargin { get; set; }

        public List<supplier> lstSupplier{ get; set; }
        public List<Product> lstProduct { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }

    public class supplier
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }
}