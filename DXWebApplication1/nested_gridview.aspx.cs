using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXWebApplication1
{
    public partial class nested_gridview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var data = new wrdEntities().organization_master.Select(x => new { x.organization_id, x.description }).ToList();
            grid.DataSource = data;
            grid.DataBind();
        }

        protected void detailGrid_DataSelect(object sender, EventArgs e)
        {
            try
            {
                int orm_id = Convert.ToInt32((sender as ASPxGridView).GetMasterRowKeyValue());
                ASPxGridView a = (sender as ASPxGridView);
                a.FindControl("detailGrid");
                a.DataSource = new wrdEntities().office_master.Select(x => new { x.office_master_id, x.organization_id, x.office_name }).Where(x => x.organization_id == orm_id).ToList();
                a.DataBind();
            }
            catch
            {

            }

        }
    }
}