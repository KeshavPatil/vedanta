using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Class1
/// </summary>
public class approver:Myclass
{
	private static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["trainingConnectionString2"].ToString());
    
    public approver()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataTable app_page_display_hod()
    { 
        if(con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = new SqlCommand("approve_query", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);

        con.Close();
        return dt;
    }

    public DataTable app_page_display_admin()
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = new SqlCommand("admin_query", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);

        con.Close();
        return dt;
    }

    public DataTable detail_page_display(int refno) 
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = new SqlCommand("retdetail", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@refno", refno);
        cmd.ExecuteNonQuery();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        con.Close();
        return dt;
    }

    public void setapproverstatus(int refno, string status) 
    { 
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = new SqlCommand("set_approver_status", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@refno", refno);
        cmd.Parameters.AddWithValue("@status", status);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public void setadminstatus(int refno, string status)
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = new SqlCommand("set_admin_status", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@refno", refno);
        cmd.Parameters.AddWithValue("@status", status);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public void setapprovername(int refno, string name)
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = new SqlCommand("set_approver_name", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@refno", refno);
        cmd.Parameters.AddWithValue("@approver", name);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public void setadminname(int refno, string name)
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = new SqlCommand("set_admin_name", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@refno", refno);
        cmd.Parameters.AddWithValue("@admin", name);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public DataTable getstatus()
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = new SqlCommand("retstatus", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.ExecuteNonQuery();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        con.Close();
        return dt;
    }

}