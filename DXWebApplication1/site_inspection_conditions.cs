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
    
    public partial class site_inspection_conditions
    {
        public Nullable<decimal> si_id { get; set; }
        public string condition { get; set; }
        public Nullable<System.DateTime> record_date { get; set; }
        public Nullable<decimal> user_id { get; set; }
        public decimal sic_id { get; set; }
        public string TRIAL032 { get; set; }
    
        public virtual user_details user_details { get; set; }
        public virtual site_inspection_report site_inspection_report { get; set; }
    }
}
