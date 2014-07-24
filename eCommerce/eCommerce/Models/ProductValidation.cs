using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace eCommerce.Models
{
    [MetadataType(typeof(ProductValidation))]
    public partial class Product
    { 
    
    }

    public class ProductValidation
    {
        public int ProductID { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        [Required,MaxLength(200)]
        public string Description { get; set; }
        [Required]
        public decimal ListPrice { get; set; }
        public int SupplierID { get; set; }
        [Required]
        public bool InStock { get; set; }
        public int CategoryID { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }

    }
}