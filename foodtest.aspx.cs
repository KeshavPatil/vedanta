using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class foodtest : System.Web.UI.Page
{
    food f = new food();
    private static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["trainingConnectionString2"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        label.Text = DateTime.Today.ToShortDateString();
        if (!IsPostBack)
        {
            populate_roomlist();
            populate_list();
        }
    }
    public void populate_roomlist() 
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        cmd.CommandText = "SELECT room_no FROM [dbo].[Master-rooms]";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;

        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }

        con.Open();

        reader = cmd.ExecuteReader();
        // Data is accessible through the DataReader object here.
        var dataTable = new DataTable();

        dataTable.Load(reader);

        con.Close();
        foreach (DataRow row in dataTable.Rows)
        {
            roomlist.Items.Add(row["room_no"].ToString());
        }
    }

    public void populate_list()
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        cmd.CommandText = "SELECT * FROM Master_Item";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;

        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }

        con.Open();

        reader = cmd.ExecuteReader();
        // Data is accessible through the DataReader object here.
        var dataTable = new DataTable();

        dataTable.Load(reader);

        con.Close();
        foreach (DataRow row in dataTable.Rows)
        {
            foodlist.Items.Add(row["Item Name"].ToString());
        }
    }
    protected void add_Click(object sender, EventArgs e)
    {
        f.insert(int.Parse(namelist.SelectedValue.ToString().Split(':')[0]), foodlist.SelectedItem.ToString(), int.Parse(qty.Text.Trim()), DateTime.Today);
        disp();
      
    }

    public void disp()
    {
        DataTable dt = new DataTable();
        dt = f.retbill(int.Parse(namelist.SelectedValue.ToString().Split(':')[0]), DateTime.Today);
        foodview.DataSource = dt;
        foodview.DataBind();
        int total = 0;
        if (foodview.Rows.Count != 0)
        {
            foreach (GridViewRow row in foodview.Rows)
            {
                total = total + Convert.ToInt32(row.Cells[4].Text);
            }
        }
        sumtotal.Text = total.ToString();
    }
    protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int refno=int.Parse(foodview.DataKeys[e.RowIndex].Values["refno"].ToString());
        String item = (foodview.DataKeys[e.RowIndex].Values["item"].ToString());
        f.del_item(refno, item, DateTime.Today);
        this.disp();
    }

    protected void edit_Click(object sender, EventArgs e)
    {
        disp();

    }
    protected void check_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        cmd.CommandText = "SELECT refno,bookedfor from [dbo].[Transaction-roombooking-v1.01] t join Final_table f on f.[Reference No] = t.refno where t.checkin<='"+DateTime.Today+"' and t.checkout>='"+DateTime.Today+"' and t.roomno='"+roomlist.SelectedItem.Text+"' and f.[Active]='True'";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;

        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }

        con.Open();

        reader = cmd.ExecuteReader();
        // Data is accessible through the DataReader object here.
        var dataTable = new DataTable();

        dataTable.Load(reader);

        con.Close();
        if (dataTable.Rows.Count != 0)
        {
            namelist.Visible = true;
            additem.Visible = true;
            edit.Visible = true;
            namelist.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                namelist.Items.Add(row["refno"].ToString() + ": " + row["bookedfor"].ToString());
            }
        }
        else
        {
            additem.Visible = false;
            edit.Visible = false;
            namelist.Visible = false;
            string message = "No active guest is this room!";
            string script = "window.onload = function(){ alert('";
            script += message;
            script += "');";
            script += "}";
            ClientScript.RegisterStartupScript(this.GetType(), "Write", script, true);
        }
    }
}