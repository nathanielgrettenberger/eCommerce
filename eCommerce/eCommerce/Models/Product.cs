//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eCommerce.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.Images = new HashSet<Image>();
            this.Reviews = new HashSet<Review>();
        }
    
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal ListPrice { get; set; }
        public int SupplierID { get; set; }
        public bool InStock { get; set; }
        public int CategoryID { get; set; }
        public decimal UnitPrice { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
