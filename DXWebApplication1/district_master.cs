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
    
    public partial class district_master
    {
        public decimal district_id { get; set; }
        public string district_name { get; set; }
        public Nullable<decimal> status_id { get; set; }
        public string TRIAL009 { get; set; }
    
        public virtual status_master status_master { get; set; }
    }
}
