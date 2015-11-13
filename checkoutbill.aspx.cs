using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.IO;
using System.Drawing;

public partial class checkoutbill : System.Web.UI.Page
{
    private static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["trainingConnectionString2"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            name.Text = (HttpUtility.UrlDecode(Request.QueryString["GuestName"]));
            company.Text = (HttpUtility.UrlDecode(Request.QueryString["CompanyName"]));
            cin.Text = (HttpUtility.UrlDecode(Request.QueryString["cin"]));
            cout.Text = (HttpUtility.UrlDecode(Request.QueryString["cout"]));
            room.Text = (HttpUtility.UrlDecode(Request.QueryString["roomno"]));
            disp();
            if (bill.Rows.Count == 0)
                export.Visible = false;
        }
        if(DateTime.Today<DateTime.Parse(cin.Text))
        {
            Checkout.OnClientClick = @"return confirm('Guest not checked in yet. Delete room booking transaction?');";
        }
    }

    void disp() 
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = new SqlCommand("retbillcheckout", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@refno", int.Parse(HttpUtility.UrlDecode(Request.QueryString["RefNo"])));
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        con.Close();


        int tot = totalcalc(dt);
        DataRow rw1 = dt.NewRow();
        rw1["Item"] = "Total : ";
        rw1["Quantity"]= 2;
        rw1["Total"] = tot;
        dt.Rows.Add(rw1);
        DataRow rf=dt.NewRow();
        DataRow rr = dt.NewRow();
        rr["Item"] = "Ref No: " + HttpUtility.UrlDecode(Request.QueryString["RefNo"]);
        rr["Quantity"] = 0;
        rr["Total"] = 0;
        dt.Rows.Add(rr);
        rf["Item"] = "Name: " + HttpUtility.UrlDecode(Request.QueryString["GuestName"]);
        rf["Quantity"] = 0;
        rf["Total"] = 0;
        dt.Rows.Add(rf);
        bill.DataSource = dt;
        bill.DataBind();
        int cnt = bill.Rows.Count;
        
        bill.Rows[cnt-3].Cells[0].ColumnSpan = 2;
        bill.Rows[cnt-3].Cells[1].Visible = false;
        bill.Rows[cnt-2].Cells[0].ColumnSpan = 3;
        bill.Rows[cnt-2].Cells[1].Visible = false;
        bill.Rows[cnt-2].Cells[2].Visible = false;
        bill.Rows[cnt-1].Cells[0].ColumnSpan = 3;
        bill.Rows[cnt-1].Cells[1].Visible = false;
        bill.Rows[cnt-1].Cells[2].Visible = false;
    }

    public int totalcalc(DataTable dt) 
    {
        int total = 0;
        if (dt.Rows.Count != 0)
        {
            foreach (DataRow row in dt.Rows)
            {
                total = total + Convert.ToInt32(row.ItemArray[2]);
            }
        }
        billtotal.Text = total.ToString();
        return total;
    }


    protected void export_Click(object sender, EventArgs e)
    {
        Response.Clear();
        Response.Buffer = true;
        Response.AddHeader("content-disposition", "attachment;filename=billexport.xls");
        Response.Charset = "";
        Response.ContentType = "application/vnd.ms-excel";
        using (StringWriter sw = new StringWriter())
        {
            HtmlTextWriter hw = new HtmlTextWriter(sw);

            //To Export all pages
            bill.AllowPaging = false;
            this.disp();

            bill.HeaderRow.BackColor = Color.White;
            foreach (TableCell cell in bill.HeaderRow.Cells)
            {
                cell.BackColor = bill.HeaderStyle.BackColor;
            }
            foreach (GridViewRow row in bill.Rows)
            {
                row.BackColor = Color.White;
                foreach (TableCell cell in row.Cells)
                {
                    if (row.RowIndex % 2 == 0)
                    {
                        cell.BackColor = bill.AlternatingRowStyle.BackColor;
                    }
                    else
                    {
                        cell.BackColor = bill.RowStyle.BackColor;
                    }
                    cell.CssClass = "textmode";
                }
            }

            bill.RenderControl(hw);

            //style to format numbers to string
            string style = @"<style> .textmode { } </style>";
            Response.Write(style);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
        }
    }

    public override void VerifyRenderingInServerForm(Control control)
    {
        /* Verifies that the control is rendered */
    }
    protected void Checkout_Click(object sender, EventArgs e)
    {
        if(DateTime.Today<DateTime.Parse(cin.Text))
        {   

            if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("set_room_no", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@refno", int.Parse(HttpUtility.UrlDecode(Request.QueryString["RefNo"])));
                cmd.Parameters.AddWithValue("@roomno", "Cancelled");
                cmd.ExecuteNonQuery();
                con.Close();

                SqlDataReader reader;
                cmd.CommandText = "DELETE from [dbo].[Transaction-roombooking-v1.01] where refno=" + int.Parse(HttpUtility.UrlDecode(Request.QueryString["RefNo"]));
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();

                reader = cmd.ExecuteReader();
                con.Close();

                Response.Redirect("checkout.aspx");
            
           
        }
        else
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("checkoutfinal", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@refno", int.Parse(HttpUtility.UrlDecode(Request.QueryString["RefNo"])));
            cmd.Parameters.AddWithValue("@checkout", DateTime.Now);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("checkout.aspx");
        }
    }
}