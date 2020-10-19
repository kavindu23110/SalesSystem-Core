using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesSystem.Models
{
    public class StockViewModel
    {
        public StockViewModel()
        {
            lstProduct = new List<Product>();
            lstSupplier = new List<supplier>();
        }
        [Required]
        public int SupplierId { get; set; }
        [Required]
        public int ProductId { get; set; }
        public int Unitcost { get; set; }
        public int SellingPrice { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public List<supplier> lstSupplier { get; set; }
        public List<Product> lstProduct { get; set; }

    }
}