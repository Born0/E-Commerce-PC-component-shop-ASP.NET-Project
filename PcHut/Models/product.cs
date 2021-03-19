//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PcHut.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class product
    {
        public int product_id { get; set; }

        [Required(ErrorMessage ="Product Name is Required")]
        public string product_name { get; set; }

        public int brand_id { get; set; }
        public int category_id { get; set; }
        public int status { get; set; }

        [Required(ErrorMessage = "Warranty is Required")]
        public string warranty { get; set; }

        [Range(1.0, Double.MaxValue, ErrorMessage = "Value should be greater than or equal to 1")]
        public double price { get; set; }
        public string image { get; set; }

        [Required(ErrorMessage = "Specification is Required")]
        public string specification { get; set; }

        public string Special { get; set; }
    
        public virtual brand brand { get; set; }
        public virtual category category { get; set; }
    }
}
