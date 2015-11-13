using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    int refno;
    servprov sp = new servprov();
    protected void Page_Load(object sender, EventArgs e)
    {
        refno = int.Parse(HttpUtility.UrlDecode(Request.QueryString["RefNo"]));
        DataTable dt = new DataTable();
        dt = sp.detail_page_display(refno);
        gname.Text = (dt.Rows[0].ItemArray[0].ToString());
        cname.Text = (dt.Rows[0].ItemArray[1].ToString());
        dname.Text = (dt.Rows[0].ItemArray[2].ToString());
        contno.Text = (dt.Rows[0].ItemArray[3].ToString());
        grade.Text = (dt.Rows[0].ItemArray[10].ToString());
        checkin.Text = (dt.Rows[0].ItemArray[5].ToString());
        checkout.Text = (dt.Rows[0].ItemArray[6].ToString());
        stayarr.Text = (dt.Rows[0].ItemArray[7].ToString());
        mealarr.Text = (dt.Rows[0].ItemArray[8].ToString());
        mofpay.Text = (dt.Rows[0].ItemArray[9].ToString());
        if (Request.QueryString["vis"]!= null)
            Button1.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Dasboard.aspx?refno=" + Request.QueryString["RefNo"].ToString() + "&cin="+checkin.Text + "&cout=" + checkout.Text + "&grade=" + grade.Text);
    }
}