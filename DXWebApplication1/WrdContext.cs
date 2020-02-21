using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DXWebApplication1
{
    public class WrdContext : DbContext
    {
        public WrdContext() : base(nameOrConnectionString: "pgcon") { }
        public DbSet<Project_Status> project_status { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project_Status>().ToTable("project_status", "public");
        }
    }
    public class Project_Status
    {
        [Key]
        public int project_status_id { get; set; }
        public int application_number { get; set; }
        public DateTime status_date { get; set; }
    }
}