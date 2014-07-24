using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace eCommerce.Models // step one: creat the using the statement for the data annotation
{
    // step two: create the partial class to set the data annotations  
    [MetadataType( typeof(CategoryValidation))]
    public partial class Category { 
    
        // step three: add metadata type annotation
      
    
           
    }
    
    public class CategoryValidation
    {
        //step 4: get the prop. for the .edmx >.tt file
        [Required, MaxLength(100)]
         public string Name { get; set; }
        [Display(Name="Parent Cateory")]
        public Nullable<int> ParentID { get; set; }
    }

}