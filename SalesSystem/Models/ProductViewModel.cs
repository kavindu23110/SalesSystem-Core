using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesSystem.Models
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            lstProduct = new List<Product>();
            lstSupplierName = new List<string>();
            lstProductCategory= new List<string>();
            lstBrandIdName = new List<string>();
            lstparts = new List<string>();
        }
        [Required]
        public string SupplierName { get; set; }
        [Required]
        public string ProductCategory { get; set; }
        [Required]
        public string ProductType{ get; set; }
        [Required]
        public string BrandName { get; set; }
        [Required]
        public int warrenty { get; set; }
        public string Details { get; set; }
        [Required]
        public float ProfitMargin { get; set; }
        public float Cost { get; set; }
        public string CustomizationType { get; set; }

        public List<Product> lstProduct { get; set; }


        public List<string> lstSupplierName { get; set; }
        public List<string> lstProductCategory { get; set; }
        public List<string> lstBrandIdName { get; set; }
        public List<string> lstparts { get; set; }
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