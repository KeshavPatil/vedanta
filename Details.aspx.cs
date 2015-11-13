using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class _Default : System.Web.UI.Page
{
    approver ap = new approver();
    int refno;
    protected void Page_Load(object sender, EventArgs e)
    {
        refno = int.Parse(HttpUtility.UrlDecode(Request.QueryString["RefNo"]));
        DataTable dt = new DataTable();
        dt = ap.detail_page_display(refno);
        //DetailsView1.DataSource = dt;
        //DetailsView1.DataBind();
        gname.Text = (dt.Rows[0].ItemArray[0].ToString());
        cname.Text = (dt.Rows[0].ItemArray[1].ToString());
        dname.Text = (dt.Rows[0].ItemArray[2].ToString());
        contno.Text = (dt.Rows[0].ItemArray[3].ToString());
        purpose.Text = (dt.Rows[0].ItemArray[4].ToString());
        checkin.Text = (dt.Rows[0].ItemArray[5].ToString());
        checkout.Text = (dt.Rows[0].ItemArray[6].ToString());
        stayarr.Text = (dt.Rows[0].ItemArray[7].ToString());
        mealarr.Text = (dt.Rows[0].ItemArray[8].ToString());
        mofpay.Text = (dt.Rows[0].ItemArray[9].ToString());
    }
    protected void accept_Click(object sender, EventArgs e)
    {
        if (Session["D_B"].ToString() == "1")
        {
            ap.setapproverstatus(refno, "Accepted");
            ap.setapprovername(refno, Session["UserID"].ToString());
        }
        else if (Session["D_B"].ToString() == "2")
        {
            ap.setadminstatus(refno, "Accepted");
            ap.setadminname(refno, Session["UserID"].ToString());
        }
        Response.Redirect("ReqStatusPage.aspx");
    }
    protected void reject_Click(object sender, EventArgs e)
    {
        if (Session["D_B"].ToString() == "1")
        {
            ap.setapproverstatus(refno, "Rejected");
            ap.setadminstatus(refno, "Rejected");
            ap.setapprovername(refno, "Rejected");
            ap.setadminname(refno, "Rejected");
        }
        else if (Session["D_B"].ToString() == "2")
        {
            ap.setadminstatus(refno, "Rejected");
            ap.setadminname(refno, "Rejected");
        }
        Response.Redirect("ReqStatusPage.aspx");
    }
}