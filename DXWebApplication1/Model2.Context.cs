﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class wrdEntities : DbContext
    {
        public wrdEntities()
            : base("name=wrdEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<appraisal_opinion_master> appraisal_opinion_master { get; set; }
        public virtual DbSet<appraisal_recommendation_master> appraisal_recommendation_master { get; set; }
        public virtual DbSet<basin_type_master> basin_type_master { get; set; }
        public virtual DbSet<day_master> day_master { get; set; }
        public virtual DbSet<department_user_master> department_user_master { get; set; }
        public virtual DbSet<designation_master> designation_master { get; set; }
        public virtual DbSet<district_master> district_master { get; set; }
        public virtual DbSet<document_category_master> document_category_master { get; set; }
        public virtual DbSet<document_details> document_details { get; set; }
        public virtual DbSet<document_type_master> document_type_master { get; set; }
        public virtual DbSet<document_type_master_kum> document_type_master_kum { get; set; }
        public virtual DbSet<drawal_mode_master> drawal_mode_master { get; set; }
        public virtual DbSet<final_recommendation> final_recommendation { get; set; }
        public virtual DbSet<furnish_master> furnish_master { get; set; }
        public virtual DbSet<holiday_master> holiday_master { get; set; }
        public virtual DbSet<industry_category_master> industry_category_master { get; set; }
        public virtual DbSet<industry_status_master> industry_status_master { get; set; }
        public virtual DbSet<industry_type_master> industry_type_master { get; set; }
        public virtual DbSet<kum_document_details> kum_document_details { get; set; }
        public virtual DbSet<kum_document_type_master> kum_document_type_master { get; set; }
        public virtual DbSet<kum_land_ownership_details> kum_land_ownership_details { get; set; }
        public virtual DbSet<kum_measures_details> kum_measures_details { get; set; }
        public virtual DbSet<kum_project_details> kum_project_details { get; set; }
        public virtual DbSet<kum_storage_details> kum_storage_details { get; set; }
        public virtual DbSet<land_ownership_details> land_ownership_details { get; set; }
        public virtual DbSet<landtype_master> landtype_master { get; set; }
        public virtual DbSet<login_statistics> login_statistics { get; set; }
        public virtual DbSet<measure_master> measure_master { get; set; }
        public virtual DbSet<measures_details> measures_details { get; set; }
        public virtual DbSet<menu_details> menu_details { get; set; }
        public virtual DbSet<menu_role_assoc> menu_role_assoc { get; set; }
        public virtual DbSet<menu_submenu_assoc> menu_submenu_assoc { get; set; }
        public virtual DbSet<month_master> month_master { get; set; }
        public virtual DbSet<office_master> office_master { get; set; }
        public virtual DbSet<office_recommendation_upload> office_recommendation_upload { get; set; }
        public virtual DbSet<office_type_master> office_type_master { get; set; }
        public virtual DbSet<organization_master> organization_master { get; set; }
        public virtual DbSet<payment_details> payment_details { get; set; }
        public virtual DbSet<payment_status> payment_status { get; set; }
        public virtual DbSet<project_details> project_details { get; set; }
        public virtual DbSet<project_next_status> project_next_status { get; set; }
        public virtual DbSet<project_status_master> project_status_master { get; set; }
        public virtual DbSet<proposed_industry_status> proposed_industry_status { get; set; }
        public virtual DbSet<recommendation_status_master> recommendation_status_master { get; set; }
        public virtual DbSet<requirement_period_master> requirement_period_master { get; set; }
        public virtual DbSet<river_basin_master> river_basin_master { get; set; }
        public virtual DbSet<river_subbasin_master> river_subbasin_master { get; set; }
        public virtual DbSet<role_master> role_master { get; set; }
        public virtual DbSet<shape_master> shape_master { get; set; }
        public virtual DbSet<site_inspection_allocation> site_inspection_allocation { get; set; }
        public virtual DbSet<site_inspection_conditions> site_inspection_conditions { get; set; }
        public virtual DbSet<site_inspection_details> site_inspection_details { get; set; }
        public virtual DbSet<site_inspection_report> site_inspection_report { get; set; }
        public virtual DbSet<status_master> status_master { get; set; }
        public virtual DbSet<status_proposed_industry> status_proposed_industry { get; set; }
        public virtual DbSet<storage_details> storage_details { get; set; }
        public virtual DbSet<structure_type_master> structure_type_master { get; set; }
        public virtual DbSet<taluk_master> taluk_master { get; set; }
        public virtual DbSet<test> tests { get; set; }
        public virtual DbSet<unit_master> unit_master { get; set; }
        public virtual DbSet<user_details> user_details { get; set; }
        public virtual DbSet<village_master> village_master { get; set; }
        public virtual DbSet<water_source_availability_master> water_source_availability_master { get; set; }
        public virtual DbSet<water_source_master> water_source_master { get; set; }
        public virtual DbSet<yes_no_master> yes_no_master { get; set; }
        public virtual DbSet<project_status> project_status { get; set; }
        public virtual DbSet<test_table> test_table { get; set; }
        public virtual DbSet<test_table2> test_table2 { get; set; }
        public virtual DbSet<vapt_tablee> vapt_tablee { get; set; }
    }
}
