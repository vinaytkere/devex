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
    
    public partial class river_subbasin_master
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public river_subbasin_master()
        {
            this.site_inspection_report = new HashSet<site_inspection_report>();
        }
    
        public decimal rsm_id { get; set; }
        public decimal river_basin_id { get; set; }
        public string river_subbasin { get; set; }
        public string TRIAL032 { get; set; }
    
        public virtual river_basin_master river_basin_master { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<site_inspection_report> site_inspection_report { get; set; }
    }
}
