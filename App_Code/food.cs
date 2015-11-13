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
public class food
{
    private static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["trainingConnectionString2"].ToString());
    public food()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void insert(int refno, String item, int qty, DateTime date)
    {
        if (con.State == ConnectionState.Open)
            con.Close();
        con.Open();
        SqlCommand cmd = new SqlCommand("ins_trans_item", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@refno", refno);
        cmd.Parameters.AddWithValue("@item", item);
        cmd.Parameters.AddWithValue("@qty", qty);
        cmd.Parameters.AddWithValue("@date", date);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public DataTable retbill(int refno, DateTime date)
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = new SqlCommand("retbill", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@refno", refno);
        cmd.Parameters.AddWithValue("@date", date);
        cmd.ExecuteNonQuery();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        con.Close();
        return dt;
    }

    public void del_item(int refno, String item, DateTime date)
    {
        if (con.State == ConnectionState.Open)
            con.Close();
        con.Open();
        SqlCommand cmd = new SqlCommand("del_trans_item", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@refno", refno);
        cmd.Parameters.AddWithValue("@item", item);
        cmd.Parameters.AddWithValue("@date", date);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public DataTable retmisgrid()
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = new SqlCommand("retmis", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.ExecuteNonQuery();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        con.Close();
        return dt;
    }
}