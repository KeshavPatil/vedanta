using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;

public partial class _Default : System.Web.UI.Page
{
    approver ap = new approver();
    protected void Page_Load(object sender, EventArgs e)
    {
        display();
    }

    public void display() 
    {
        DataTable dt = new DataTable();
        dt = ap.getstatus();
        statusgrid.DataSource = dt;
        statusgrid.DataBind();
        user.Text = "Welcome " + Session["UserID"].ToString();
    }
    protected void logout_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        Session.Abandon();
        Response.Redirect("Login.aspx");
    }


    protected void statusgrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        
        DataTable dt = new DataTable();
        dt = ap.getstatus();
        statusgrid.DataSource = dt;
        statusgrid.PageIndex = e.NewPageIndex;
        statusgrid.DataBind();
    }
   
}