using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstApp.Models
{
    public class Products
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Product name is Required")]
        [StringLength(100,MinimumLength =2,ErrorMessage ="Requires atleast 2 characters")]
        public string proName { get; set; }
        [Required(ErrorMessage = "Product name is Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Requires atleast 2 characters")]
        public string proCategory { get; set; }
        [Required(ErrorMessage = "Product name is Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Requires atleast 2 characters")]
        public string proDescription { get; set; }
        [Required(ErrorMessage = "Product name is Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Requires atleast 2 characters")]
        public string proMade { get; set; }
        [Required(ErrorMessage = "Product name is Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Requires atleast 2 characters")]
        public string proPrice { get; set; }
    }
}