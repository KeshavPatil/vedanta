using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class GrandUnifiedLoggedIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["D_B"] == null)
        {
            linkGoSomewhere.Visible = false;
            Button1.Visible = false;
            login.Text = " You are either not Logged in or your Session has expired. Please Sign In!";
            login.Visible = true;
            Button2.Visible = true;
        }
        else
        {
        if (Convert.ToInt32(Session["D_B"].ToString()) == 0) 
        {
            user.Text = "Welcome " + Session["UserID"].ToString();
            logreq.Visible = true;
            reqstat.Visible = true;
        }
        else if (Convert.ToInt32(Session["D_B"].ToString()) == 1 || Convert.ToInt32(Session["D_B"].ToString()) == 2)
        {
            user.Text = "Welcome " + Session["UserID"].ToString();
            logreq.Visible = true;
            reqstat.Visible = true;
            pendreq.Visible = true;
            if (Convert.ToInt32(Session["D_B"].ToString()) == 2)
                dashboard.Visible = true;
        }
        else if (Convert.ToInt32(Session["D_B"].ToString()) == 3)
        {
            user.Text = "Welcome " + Session["UserID"].ToString();
            sodexo.Visible = true;
        }
        }
       
    }
    protected void logout_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        Session.Abandon();
        Response.Redirect("Login.aspx");
    }

    protected void login_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}