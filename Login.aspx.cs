using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;
using System.Text;

public partial class _Login : System.Web.UI.Page
{
    Myclass mc;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void login_Click(object sender, EventArgs e)
    {
        
        mc = new Myclass();
        DataTable dt = new DataTable();
        dt = mc.checkpass(userid.Text, pass.Text);
        if (dt.Rows.Count != 0)
        {
            //StringBuilder mroles = new StringBuilder();
            Session["UserID"] = userid.Text;
            if (userid.Text == "Tushar")
            {

                Session["D_B"] = '0';
                //mroles.Append("User");
                //Session["Role"] = "User";
                //Response.Write(mroles.ToString());
                //FormsAuthenticationTicket fat = new FormsAuthenticationTicket(1, userid.Text, DateTime.Now, DateTime.Now.AddMinutes(20), false, "User", FormsAuthentication.FormsCookiePath);
                //Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(fat)));
                // FormsAuthentication.RedirectFromLoginPage(userid.Text,false);
                FormsAuthentication.RedirectFromLoginPage(userid.Text, createPersistentCookie: true);
            }
            else if (userid.Text == "HOD")
            {
                Session["D_B"] = '1';
                FormsAuthentication.RedirectFromLoginPage(userid.Text, createPersistentCookie: true);
            }
            else if (userid.Text == "Admin")
            {
                Session["D_B"] = '2';
                FormsAuthentication.RedirectFromLoginPage(userid.Text, createPersistentCookie: true);
            }
            else if (userid.Text == "Sodexo")
            {
                Session["D_B"] = '3';
                FormsAuthentication.RedirectFromLoginPage(userid.Text, createPersistentCookie: true);
            }

        }
        else
        {
            string message = "Incorrect Username or password";
            string script = "window.onload = function(){ alert('";
            script += message;
            script += "')};";

            ClientScript.RegisterStartupScript(this.GetType(), "Write", script, true);

        }
    }
}