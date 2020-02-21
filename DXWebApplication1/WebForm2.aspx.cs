using DevExpress.Web;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXWebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var om = new wrdEntities().office_master.Select(x=>new { oid = x.office_master_id,on = x.office_name,}).ToList(); ;
            MainGrid.DataSource = om;
            MainGrid.DataBind();
        }

        protected void detailGrid_DataBinding(object sender, EventArgs e)
        {
            try
            {
                ASPxGridView detailGrid = (ASPxGridView)sender;
                int id = Convert.ToInt32(detailGrid.GetMasterRowKeyValue());
                var cont = new wrdEntities();

                var detailData = cont.project_status.Join(cont.project_status_master, ps => ps.project_status_id, psm => psm.proj_status_id,
                    (ps, psm) => new { ps.application_number, ps.office_master_id, psm.display_status }).Where(x => x.office_master_id == id).ToList();

                detailGrid.DataSource = detailData;
            }
            catch
            {

            }

        }
    }
}