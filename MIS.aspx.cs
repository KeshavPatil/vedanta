using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class MIS : System.Web.UI.Page
{
    food f = new food();
    protected void Page_Load(object sender, EventArgs e)
    {
        disp();
    }

    public void disp()
    {
        DataTable dt = new DataTable();
        dt = f.retmisgrid();
        misgrid.DataSource = dt;
        misgrid.DataBind();
        int row_count = misgrid.Rows.Count;
        for (int i = 0; i < row_count; i++)
        {
            misgrid.Rows[i].Cells[6].Text = Convert.ToDateTime(misgrid.Rows[i].Cells[6].Text).ToString("dd/MM/yyyy");
            misgrid.Rows[i].Cells[5].Text = Convert.ToDateTime(misgrid.Rows[i].Cells[5].Text).ToString("dd/MM/yyyy");
        }
    }
    protected void misgrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        misgrid.PageIndex = e.NewPageIndex;
    }
}