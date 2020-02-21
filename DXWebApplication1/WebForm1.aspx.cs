﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXWebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var con = new schoolEntities().Courses.Select(x => x).ToList();

            grid.DataSource = con;
            grid.DataBind();
        }
    }
}