using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    Myclass mc = new Myclass();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void sub_Click(object sender, EventArgs e)
    {
        if (mc.passeq(passw.Text, repass.Text))
        {
            mc.insert(usname.Text, passw.Text);
            Response.Write("Successfully Registered");
        }
        else
            Response.Write("Passwords did not match.");
    }
}