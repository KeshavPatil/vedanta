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
/// is the master class for general purposes such as insertion and display of records among other functions. Will be extended by other classes.
/// </summary>
public class Myclass
{
    int refno;
    private static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["trainingConnectionString2"].ToString());
    public Myclass()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataTable checkpass(String username, String password)
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = new SqlCommand("checkpass", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", username);
        cmd.Parameters.AddWithValue("@pass", password);
        cmd.ExecuteNonQuery();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        con.Close();
        return dt;
    }

    public void insert(String username, String pass)
    {
        if (con.State == ConnectionState.Open)
            con.Close();
        con.Open();
        SqlCommand cmd = new SqlCommand("insusepass", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", username);
        cmd.Parameters.AddWithValue("@pass", pass);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public Boolean passeq(String pass1, String pass2)
    {
        return pass1.Equals(pass2);
    }

    public Boolean checkno(String no) 
    {
        int count = 0;
        foreach(char c in no)
        {
            if (c < '0' || c > '9')
                return false;
            else
                count++;
        }
        if (count != 10)
            return false;
        else
            return true;
    }
  
    public int inserintotable(String guest_name, String SSL_emp, String grade, String comp_name, String designation, String contactno, String purpose, String checkin, String checkout, String checkintime, String mofarrival, String approvedinpo, String pono, String stayarr, String mealarr, String mofpayment, String approvingauth,string user) 
    {
        refno = refnogenerate();
        if (con.State == ConnectionState.Open)
            con.Close();
        con.Open();
        SqlCommand cmd = new SqlCommand("insert_Final_table", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ref_no", refno);  //done//Have to change this to automatically generated from table[0][0] order by desc + 1.
        cmd.Parameters.AddWithValue("@guest_name", guest_name);
        cmd.Parameters.AddWithValue("@SSL_emp", SSL_emp);
        cmd.Parameters.AddWithValue("@grade", grade);
        cmd.Parameters.AddWithValue("@comp_name", comp_name);
        cmd.Parameters.AddWithValue("@designation", designation);
        cmd.Parameters.AddWithValue("@contactno", contactno);
        cmd.Parameters.AddWithValue("@purpose", purpose);
        cmd.Parameters.AddWithValue("@checkin", checkin);
        cmd.Parameters.AddWithValue("@checkout", checkout);
        cmd.Parameters.AddWithValue("@checkintime", checkintime);
        cmd.Parameters.AddWithValue("@mofarrival", mofarrival);
        cmd.Parameters.AddWithValue("@approvedinpo", approvedinpo);
        cmd.Parameters.AddWithValue("@pono", pono);
        cmd.Parameters.AddWithValue("@stayarr", stayarr);
        cmd.Parameters.AddWithValue("@mealarr", mealarr);
        cmd.Parameters.AddWithValue("@mofpayment", mofpayment);
        cmd.Parameters.AddWithValue("@approvingauth", approvingauth);
        cmd.Parameters.AddWithValue("@requestername", user);
        cmd.Parameters.AddWithValue("@approverstatus", "Pending");
        cmd.Parameters.AddWithValue("@adminstatus", "Pending");
        cmd.Parameters.AddWithValue("@room_no", "Pending");
        cmd.ExecuteNonQuery();
        con.Close();
        return refno;
    }

    public void insertintoapproveradmin() 
    {
        if (con.State == ConnectionState.Open)
            con.Close();
        con.Open();
        SqlCommand cmd = new SqlCommand("insert_approveradmin", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@refno", refno);
        cmd.Parameters.AddWithValue("@approver","Pending");
        cmd.Parameters.AddWithValue("@admin", "Pending");
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public int refnogenerate() 
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = new SqlCommand("retref", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.ExecuteNonQuery();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        con.Close();
        if(dt.Rows.Count == 0)
            return 0;
        string str = (dt.Rows[0].ItemArray[0].ToString());
        int i = int.Parse(str) + 1;
        return i;
    }
}

 