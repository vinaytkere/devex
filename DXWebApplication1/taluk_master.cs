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
    
    public partial class taluk_master
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public taluk_master()
        {
            this.village_master = new HashSet<village_master>();
        }
    
        public int taluk_id { get; set; }
        public string taluk_name { get; set; }
        public int district_id { get; set; }
        public Nullable<decimal> status_id { get; set; }
        public string TRIAL035 { get; set; }
    
        public virtual status_master status_master { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<village_master> village_master { get; set; }
    }
}
