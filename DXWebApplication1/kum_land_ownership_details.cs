//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DXWebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class kum_land_ownership_details
    {
        public decimal ld_id { get; set; }
        public Nullable<decimal> kum_id { get; set; }
        public Nullable<int> landtype_id { get; set; }
        public Nullable<decimal> acre { get; set; }
        public Nullable<decimal> gunta { get; set; }
        public string TRIAL015 { get; set; }
    
        public virtual landtype_master landtype_master { get; set; }
        public virtual kum_project_details kum_project_details { get; set; }
    }
}
