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
    
    public partial class water_source_availability_master
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public water_source_availability_master()
        {
            this.kum_project_details = new HashSet<kum_project_details>();
            this.project_details = new HashSet<project_details>();
            this.site_inspection_report = new HashSet<site_inspection_report>();
        }
    
        public int wsa_id { get; set; }
        public string description { get; set; }
        public string TRIAL051 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kum_project_details> kum_project_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<project_details> project_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<site_inspection_report> site_inspection_report { get; set; }
    }
}
