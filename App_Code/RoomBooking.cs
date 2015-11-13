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
public class RoomBooking
{
    private static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["trainingConnectionString2"].ToString());
   
	public RoomBooking()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    public DataTable display_dash()
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = new SqlCommand("dash_query", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
        DataTable dt1 = new DataTable();
        adp1.Fill(dt1);

        con.Close();
        return dt1;
    }

    public DataTable display_dash1()
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = new SqlCommand("dash_query1", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
        DataTable dt1 = new DataTable();
        adp1.Fill(dt1);

        con.Close();
        return dt1;
    }

    public DataTable display_dash2()
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = new SqlCommand("dash_query2", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
        DataTable dt1 = new DataTable();
        adp1.Fill(dt1);

        con.Close();
        return dt1;
    }

    public void insertintotrans(int refno, string roomno, DateTime checkin, DateTime checkout, int bedno)
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = new SqlCommand("inserttransroom", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@refno", refno);
        cmd.Parameters.AddWithValue("@roomno", roomno);
        cmd.Parameters.AddWithValue("@checkin", checkin);
        cmd.Parameters.AddWithValue("@checkout", checkout);
        cmd.Parameters.AddWithValue("@status", 1);
        cmd.Parameters.AddWithValue("@bedno", bedno);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public void update_room_final_table(int refno, string roomno)
    {
        if (con.State == ConnectionState.Open)
            con.Close();
        con.Open();
        SqlCommand cmd = new SqlCommand("set_room_no", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@refno", refno);
        cmd.Parameters.AddWithValue("@roomno", roomno);
        cmd.ExecuteNonQuery();
        con.Close();
    }
}