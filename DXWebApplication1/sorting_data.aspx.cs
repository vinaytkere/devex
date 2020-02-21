using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXWebApplication1
{
    public partial class sorting_data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grid.DataSource = new ChinookEntities().Employees.Select(x => new
            {
                employeeid = x.EmployeeId,
                fullname = x.FirstName + "" + x.LastName,
                title = x.Title,
                country = x.Country,
                city = x.City
            }).ToList();

            grid.DataBind();
        }
    }
}