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
    
    public partial class document_type_master_kum
    {
        public decimal doc_type_id { get; set; }
        public string description { get; set; }
        public Nullable<int> doc_category_id { get; set; }
        public Nullable<decimal> max_size_limit { get; set; }
        public Nullable<int> mandatory_col { get; set; }
        public string TRIAL009 { get; set; }
    
        public virtual document_category_master document_category_master { get; set; }
    }
}