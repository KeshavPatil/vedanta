using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Default3 : System.Web.UI.Page
{
    approver ap = new approver();
    protected void Page_Load(object sender, EventArgs e)
    {
        disp();
    }
    public void disp()
    {
        if (int.Parse(Session["D_B"].ToString()) == 1)
        {
            DataTable dt = new DataTable();
            dt = ap.app_page_display_hod();
            shortdetails.DataSource = dt;
            shortdetails.DataBind();
        }
        else if (int.Parse(Session["D_B"].ToString()) == 2)
        {
            DataTable dt = new DataTable();
            dt = ap.app_page_display_admin();
            shortdetails.DataSource = dt;
            shortdetails.DataBind();
        }
    }
}