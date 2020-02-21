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
    
    public partial class user_details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user_details()
        {
            this.document_details = new HashSet<document_details>();
            this.kum_document_details = new HashSet<kum_document_details>();
            this.kum_project_details = new HashSet<kum_project_details>();
            this.kum_project_details1 = new HashSet<kum_project_details>();
            this.login_statistics = new HashSet<login_statistics>();
            this.project_details = new HashSet<project_details>();
            this.project_details1 = new HashSet<project_details>();
            this.site_inspection_conditions = new HashSet<site_inspection_conditions>();
            this.site_inspection_details = new HashSet<site_inspection_details>();
            this.site_inspection_details1 = new HashSet<site_inspection_details>();
            this.site_inspection_report = new HashSet<site_inspection_report>();
            this.site_inspection_report1 = new HashSet<site_inspection_report>();
            this.project_status = new HashSet<project_status>();
        }
    
        public decimal user_id { get; set; }
        public string email_id { get; set; }
        public string username { get; set; }
        public decimal role_id { get; set; }
        public string industry_name { get; set; }
        public decimal mobile_number { get; set; }
        public string email_auth_code { get; set; }
        public string mobile_auth_code { get; set; }
        public string password { get; set; }
        public Nullable<decimal> organization_id { get; set; }
        public Nullable<decimal> office_id { get; set; }
        public Nullable<decimal> designation_id { get; set; }
        public Nullable<decimal> reporting_office_id { get; set; }
        public Nullable<decimal> reporting_role_id { get; set; }
        public Nullable<decimal> status_id { get; set; }
        public string TRIAL038 { get; set; }
    
        public virtual designation_master designation_master { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<document_details> document_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kum_document_details> kum_document_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kum_project_details> kum_project_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kum_project_details> kum_project_details1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<login_statistics> login_statistics { get; set; }
        public virtual office_master office_master { get; set; }
        public virtual office_master office_master1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<project_details> project_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<project_details> project_details1 { get; set; }
        public virtual role_master role_master { get; set; }
        public virtual role_master role_master1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<site_inspection_conditions> site_inspection_conditions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<site_inspection_details> site_inspection_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<site_inspection_details> site_inspection_details1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<site_inspection_report> site_inspection_report { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<site_inspection_report> site_inspection_report1 { get; set; }
        public virtual status_master status_master { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<project_status> project_status { get; set; }
    }
}
