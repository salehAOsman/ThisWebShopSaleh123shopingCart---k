using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShopSaleh1.Models
{
    public class Product
    {
//*8/3
        [HiddenInput(DisplayValue =false)]
        public int Id { get; set; }

        [Required(ErrorMessage="Please enter a product name")]
        public string Name { get; set; }

        [Required]
        [Range(0.01,double.MaxValue,ErrorMessage ="Please enter a positive price")]
        public double Price { get; set; }

        [Required(ErrorMessage ="Please enter the description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter the quantity that Available in the storage ")]
        public int AvailableStorage { get; set; }

        
    }
    //*8/3
}