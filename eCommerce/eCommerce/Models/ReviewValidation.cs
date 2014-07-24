using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace eCommerce.Models
{
  
    }
[MetadataType(typeof(ReviewValidation))]
    public partial class Review 
    { 
    
      
 
    public class ReviewValidation
    {

        public int ReviewID { get; set; }
        public string Username { get; set; }
       [Required, MaxLength(50)]
        public string Title { get; set; }
        [Required,MaxLength(500)]
        public string Body { get; set; }
        public double Rating { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int ProductID { get; set; }
    }
        
}