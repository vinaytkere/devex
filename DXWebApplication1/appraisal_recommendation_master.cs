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
    
    public partial class appraisal_recommendation_master
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public appraisal_recommendation_master()
        {
            this.site_inspection_details = new HashSet<site_inspection_details>();
        }
    
        public decimal appr_ar_id { get; set; }
        public string description { get; set; }
        public string TRIAL009 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<site_inspection_details> site_inspection_details { get; set; }
    }
}
