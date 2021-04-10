﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Catalogo
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WSDB.BDSoapClient WS = new WSDB.BDSoapClient();

            DataSet ds = WS.GetData();

            GridView1.DataSource = ds.Tables[0];

            GridView1.DataBind();
        }
    }
}