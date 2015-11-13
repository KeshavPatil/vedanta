using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    servprov sp = new servprov();
    protected void Page_Load(object sender, EventArgs e)
    {
        disp();
    }

    public void disp() 
    {
        DataTable dt = new DataTable();
        dt = sp.retappreqpage();
        appreqgrid.DataSource = dt;
        appreqgrid.DataBind();
    }
}