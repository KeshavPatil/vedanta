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
public class servprov:approver
{
    private static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["trainingConnectionString2"].ToString());
    public servprov()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataTable retappreqpage()
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = new SqlCommand("retappreqpage", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        con.Close();
        return dt;
    }

    public DataTable retpenreqpage()
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = new SqlCommand("retpenreqpage", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        con.Close();
        return dt;
    }
}