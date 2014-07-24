using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace eCommerce.Models
{
    [MetadataType(typeof(SuppliersValidation))]
    public partial class Supplier
    { 
    
    }
    public class SuppliersValidation
    {
        public int SuppliersID { get; set; }
        [Required, MaxLength(250)]
        public string Name { get; set; }
        [Required,MaxLength()]
        public string Description { get; set; }
    }
}