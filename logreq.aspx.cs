using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ntspl;

public partial class Default3 : System.Web.UI.Page
{
    Myclass mc = new Myclass();
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
    protected void sub_Click(object sender, EventArgs e)
    {
        
        try
        {   

            int count = 0;
            //if (mc.checkno(contactno.Text) != true)
            //{
            //    Response.Write("Enter valid contact number." + Environment.NewLine);
            //    count++;
            //}

            if (DateTime.Parse(checkin.Text) > DateTime.Parse(checkout.Text))
            {
                count++;
                string message = "Incorrect checkout date";
                string script = "window.onload = function(){ alert('";
                script += message;
                script += "')};";

                ClientScript.RegisterStartupScript(this.GetType(), "Write", script, true);
                
            }
            //if (string.IsNullOrWhiteSpace(gname.Text))
            //{
            //    Response.Write(" Please enter name." + Environment.NewLine);
            //    count++;
            //}
            if ((sslemp.SelectedItem.Text.Equals("Yes")) == true && string.IsNullOrWhiteSpace(grade.Text))
            {
                count++;
                string message = "Enter Grade ";
                string script = "window.onload = function(){ alert('";
                script += message;
                script += "')";
                script += " };";
                ClientScript.RegisterStartupScript(this.GetType(), "Write", script, true);
                
            }
            //if (string.IsNullOrWhiteSpace(purpose.Text))
            //{
            //    Response.Write(" Please enter purpose." + Environment.NewLine);
            //    count++;
            //}
            //if (string.IsNullOrWhiteSpace(checkintime.Text))
            //{
            //    Response.Write(" Please enter check in time." + Environment.NewLine);
            //    count++;
            //}
            //if (string.IsNullOrWhiteSpace(mofarrival.Text))
            //{
            //    Response.Write(" Please enter mode of arrival." + Environment.NewLine);
            //    count++;
            //}
            if (count == 0)
            {
                int refno;
                if (!grade.Enabled)
                    refno = mc.inserintotable(gname.Text, sslemp.SelectedItem.Text, " ", company.Text, designation.Text, contactno.Text, purpose.Text, checkin.Text, checkout.Text, DateTime.ParseExact(checkintime.Text, "hh : mm : tt", System.Globalization.CultureInfo.CurrentCulture).ToString(), mofarrival.Text, RadioButtonList1.SelectedItem.Text, pono.Text, stayarr.SelectedItem.Text, mealarr.SelectedItem.Text, mofpay.SelectedItem.Text, DropDownList2.SelectedItem.Text, Session["UserID"].ToString());
                else
                    refno = mc.inserintotable(gname.Text, sslemp.SelectedItem.Text, grade.SelectedItem.Text, company.Text, designation.Text, contactno.Text, purpose.Text, checkin.Text, checkout.Text, DateTime.ParseExact(checkintime.Text,"hh : mm : tt",System.Globalization.CultureInfo.CurrentCulture).ToString(), mofarrival.Text, RadioButtonList1.SelectedItem.Text, pono.Text, stayarr.SelectedItem.Text, mealarr.SelectedItem.Text, mofpay.SelectedItem.Text, DropDownList2.SelectedItem.Text, Session["UserID"].ToString());
                mc.insertintoapproveradmin();
                string message = "Successfully Registered. Your reference no is: " + refno;
                string url = "GrandUnifiedLoggedIn.aspx";
                string script = "window.onload = function(){ alert('";
                script += message;
                script += "');";
                script += "window.location = '";
                script += url;
                script += "'; }";
                ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script, true);
            }
        }
        catch (System.NullReferenceException)
        {
            string message = "Session timed out or user not signed in.";
            string url = "Login.aspx";
            string script = "window.onload = function(){ alert('";
            script += message;
            script += "');";
            script += "window.location = '";
            script += url;
            script += "'; }";
            ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script, true);
        }
    
    }

    public void gradelistchanged(object sender, EventArgs e)
    {
        if (sslemp.SelectedItem.Text.Equals("Consultant"))
        {
            grade.Enabled = false;
        }
        else
            grade.Enabled = true;
        //Response.Write(grade.SelectedItem.Text+'1');
    }
    protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs e)
    {
        if (e.Value.Length == 10)
        {
            e.IsValid = true;
            Response.Write("goingnot");
        }
        else
        {
            e.IsValid = false;
            Response.Write("going");
        }
    }
}