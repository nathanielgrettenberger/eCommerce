using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace eCommerce.Controllers
{
    [MetadataType(typeof(ImageValidation))]
    public partial class Image
    { 
    
    }
    public class ImageValidation
    {
        public int ImageID { get; set; }
        public int ProductID { get; set; }

        public string ImageURL { get; set; }
        [Required, MaxLength()]
        public string Description { get; set; }

    }
}