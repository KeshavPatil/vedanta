using System;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;


public partial class Dasboard : System.Web.UI.Page
{
    RoomBooking rb = new RoomBooking();
    
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            PopulateYear();
            ddlMonth.SelectedValue = DateTime.Now.Month.ToString();
            ddlYear.SelectedValue = DateTime.Now.Year.ToString(); 
            createtable(Convert.ToInt32(ddlMonth.SelectedValue), Convert.ToInt16(ddlYear.SelectedValue));               //Dipalying Dashboard
        }
        if (Request.QueryString["refno"] != null)
        {   
            refno.Text = Request.QueryString["refno"].ToString();               // 
            cin.Text = Request.QueryString["cin"].ToString();                   //getting queries from Service provider room booking  page(Soddetails.aspx)
            cout.Text = Request.QueryString["cout"].ToString();                 // to check for panel
            grade.Text = Request.QueryString["grade"].ToString();               //
        }
        else Panel1.Visible = false;
    }
    public DataTable gettransactable()
    {
        DataTable transactab = new DataTable();                                 //getting transaction booking table
        return transactab = rb.display_dash2(); 
    }
    public DataTable getroomtable()
    {
        DataTable roomtab = new DataTable();
        return roomtab = rb.display_dash1();                                    // getting master room table
    }
    public void createtable(int month, int year)
    {
       
        System.Globalization.DateTimeFormatInfo forb = new System.Globalization.DateTimeFormatInfo();                     
        DataTable roomtab = getroomtable();
        
        int Year = DateTime.Now.Year;                                           //
        int Month = DateTime.Now.Month;                                         //Getting no of days in the month displayed so to create columns
        int today = Convert.ToInt16(DateTime.Today.ToString("dd")); 
        int noofdays = System.DateTime.DaysInMonth(year, month);                //
        
        DataTable dt = new DataTable();                                         // temporary datatables for creating gridview   dt for maingridview
        DataTable dt1 = new DataTable();                                        // dt1 for Header
        
                                
        int nofofroom1 = roomtab.Rows.Count;                                    //
        
        dt.Columns.Add("RoomNo  :");                                            //Adding first column Head
        dt1.Columns.Add("RoomNo  :");
        for (int i = 1; i <= noofdays; i++)
        {
          
            String mnth = ddlMonth.SelectedItem.Text;
            DateTime frmdate = Convert.ToDateTime(i.ToString()+"/" + mnth + "/" + year);    
            var x = frmdate.ToString("MMM dd");                                 
            string[] word = x.Split(' ');                                   
           
            dt.Columns.Add(word[0] + "    " + word[1]);                          //Adding other column head
            dt1.Columns.Add(word[0] + "    " + word[1]);
           
            
        }

        int cntbed = 0;
        for (int j = 1; j <= nofofroom1; j++)                                     //Adding room nos. in first column
        {
            DataRow rw = dt.NewRow();
            rw["RoomNo  :"] = roomtab.Rows[j - 1].ItemArray[1] ;
            dt.Rows.Add(rw);
            cntbed++;
            if (Convert.ToInt16(roomtab.Rows[j - 1].ItemArray[3]) == 2)
            {
                DataRow rw1 = dt.NewRow();
                rw1["RoomNo  :"] = roomtab.Rows[j - 1].ItemArray[1] + ": 2nd ";
                dt.Rows.Add(rw1);
                cntbed++;

            }
            
            dt.AcceptChanges(); 
        }
        
        DataRow rw2 = dt1.NewRow();                                               //Adding a row into a grid view with header                                     
       // rw2["RoomNo  :"] = "AluminiumnSQ";                                        // to adjust the width of header      
        dt1.Rows.Add(rw2);
        dt1.AcceptChanges();
        GridView2.DataSource =dt1;                                                //
        GridView2.DataBind();                                                     //binding the data to griview with header  

        GridView2.Rows[0].Style.Add("opacity", "0");                              // Hiding the row of the gridview with header

        GridView1.DataSource = dt;                                                //
        GridView1.DataBind();                                                     // Binding the main gridview with rooms nos.
        
       
        for (int i = 0; i <= noofdays; i++)                                       // Aligning header cells
        {
            GridView2.HeaderRow.Cells[i].Style.Add("text-align", "center");
           
           
        }

        for (int j = 0; j < cntbed; j++)
        {
            GridView1.Rows[j].Cells[0].Style.Add("background-color", "#22cc99");
            GridView1.Rows[j].Cells[0].Style.Add("border", "4px groove #fff");
            GridView1.Rows[j].Cells[0].Style.Add("text-align", "center");
            GridView1.Rows[j].Cells[0].Style.Add("width", "100px");
            GridView1.Rows[j].Style.Add("height", "50px");
            
            if (month == Month && year == Year)
            {
                GridView1.Rows[j].Cells[today].Style.Add("background-color", "#33FF99");        //for highlighting today
                GridView2.HeaderRow.Cells[today].Style.Add("background-color", "#33FF99");
                GridView2.HeaderRow.Cells[today].Style.Add("color", "black");
            }
        }


        if (!IsPostBack)
        {
            listpopulate(dt);                                                         //populate list in panel1  only for service provider access
        }
        getdata();                                                                // Getting the booking log in the main gridview
        if (month == 12)
        {
            forlab.InnerText = forb.GetAbbreviatedMonthName(1).ToString();
            backlab.InnerText = forb.GetAbbreviatedMonthName(month - 1).ToString();
        }
        else if (month == 1)
        {
            backlab.InnerText = forb.GetAbbreviatedMonthName(12).ToString();
            forlab.InnerText = forb.GetAbbreviatedMonthName(month + 1).ToString();
        }
        else
        {
            forlab.InnerText = forb.GetAbbreviatedMonthName(month + 1).ToString();
            backlab.InnerText = forb.GetAbbreviatedMonthName(month - 1).ToString();
        }
        
        
    }

    void listpopulate(DataTable GridView1) 
    {
        if (Panel1.Visible == true)
        {
            foreach (DataRow row in GridView1.Rows)
                roomlist.Items.Add(row["RoomNo  :"].ToString());
        }
    }


    void getdata()
    {


        DataTable transactab =gettransactable();                                                //getting transaction table

        DataTable roomtab = getroomtable();                                                   //getting master room table

        
        int dispmonth = Convert.ToInt16(ddlMonth.SelectedValue);                        //getting displayed month 
        int dispyear = Convert.ToInt16(ddlYear.SelectedValue);                          //    & year

        var bookrowcnt = transactab.Rows.Count;                                         // no of rows in transaction booking table
        int noofdays = System.DateTime.DaysInMonth(dispyear, dispmonth);    
        
        int gridrowcnt = GridView1.Rows.Count;
        int gridrow;

        
          
       
        int gridcol = GridView1.Rows[1].Cells.Count;
           
        for (int bookrow = 0; bookrow <bookrowcnt; bookrow++)                               
        {   
           
            string tobroom = transactab.Rows[bookrow].ItemArray[1].ToString();
            int tobroomid = Convert.ToInt16( transactab.Rows[bookrow].ItemArray[7].ToString());
            
            gridrow = 0;
            for (int u = 0; u < tobroomid - 1; u++)
            {

                int j = Convert.ToInt16(roomtab.Rows[u].ItemArray[3]);
                if (j != 0)
                    gridrow += j;
                else
                    gridrow++;

            }
            //Response.Write(gridrow + "  ;::");
            //int gridcolumn = Convert.ToInt16(transactab.Rows[bookrow].ItemArray[2].ToString());
            string q = transactab.Rows[bookrow].ItemArray[2].ToString();                    //
            DateTime t = Convert.ToDateTime(q);                                      //
            string indate = t.ToString("u").Substring(8, 2);                         //finding the column of checkin
            int in_month = Convert.ToInt32(t.ToString("u").Substring(5, 2));         //
            int in_year = Convert.ToInt16(t.ToString("u").Substring(0, 4));          //
            int b = Convert.ToInt16(indate);                                         //
         //   Response.Write("t:  " + col_month + "   " + t.ToString("u").Substring(5, 2) + "<BR/>");
          
            string q1 = transactab.Rows[bookrow].ItemArray[3].ToString();            //
            DateTime t1 = Convert.ToDateTime(q1);                                    //
            string outdate = t1.ToString("u").Substring(8, 2);                       // finding the column of checkout 
            int b1 = Convert.ToInt16(outdate);                                       // finding the date
            int out_year = Convert.ToInt16(t1.ToString("u").Substring(0, 4));  
            int out_month = Convert.ToInt32(t1.ToString("u").Substring(5, 2));      //
      //      Response.Write("t1:  "+ out_month + "   " + t1.ToString("u").Substring(5, 2) + "<BR/>");
            int span = b1 - b + 1;
            int span1 = 0;
            if (out_month != in_month)
            {
                span = noofdays - b + 1;
                span1 = b1;

            }
            if (Convert.ToInt16(transactab.Rows[bookrow].ItemArray[6]) == 2) gridrow++;             //if booked with 2nd bed then going on that row
            
                                                                    // Displaying booked dates on dashboard


            if (in_year == out_year && in_year == dispyear)                                         //if checkin checkout with same year and dispay
            {                                                                                       //year is same
                if (in_month == out_month && out_month == dispmonth)
                {
                    spanto(transactab, gridrow, b , span, bookrow);                                 
                }

                if (out_month != in_month)
                {
                    if (in_month == dispmonth)
                    {
                        spanto(transactab, gridrow, b, span, bookrow);

                    }
                    if (in_month < dispmonth && out_month == dispmonth)
                    {
                        spanupto(transactab, gridrow, span1, bookrow);

                    }

                    if (in_month < dispmonth && dispmonth < out_month)
                    {
                       
                        totalspan(transactab, gridrow, noofdays, bookrow);
                    }
                }
            }
            if (in_year != out_year && (dispyear >= in_year || dispyear <= out_year))
            {
                if ( dispyear == in_year)
                {
                    if(dispmonth == in_month)
                    {
                        spanto(transactab,gridrow, b, span, bookrow);
                    }
                    else if (dispmonth >= in_month)
                    { 
                        totalspan(transactab,gridrow, noofdays, bookrow);
                    }   
                }
                else if (dispyear > in_year && dispyear < out_year)
                {
                    totalspan(transactab,gridrow,noofdays,bookrow);
                }
                else if (dispyear == out_year)
                {
                    if ( dispmonth == out_month)
                    {
                        spanupto(transactab, gridrow, span1, bookrow);
                    }
                    else if (dispmonth < out_month)
                    {
                        totalspan(transactab, gridrow, noofdays, bookrow);
                    }
                }

            }
         }//for loop for bookrow ends here
        GridView1.Style.Add("width", "100%");
        GridView2.HeaderRow.Style.Add("height", "50px");
        GridView1.HeaderRow.Style.Add("height", "40px");
        GridView2.HeaderRow.Style.Add("font-size", "18px");
        GridView2.HeaderRow.Cells[0].Style.Add("border", "1px solid white");
        GridView2.HeaderRow.Cells[0].Style.Add("width", "100px");
        
        
    }



    Random r1 = new Random();
    private void spanto(DataTable transactab, int gridrow, int b, int span, int bookrow)
    {
        GridView1.Rows[gridrow].Cells[b].ColumnSpan += span;
        int k;
        for ( k = 1; k < span; k++)
        {
            GridView1.Rows[gridrow].Cells[b + k].Visible = false;

        }
       // Response.Write("span: " + span + ", k: " + k + " For: " + transactab.Rows[bookrow].ItemArray[5] + "gridrow:" + gridrow +"<BR />"); 
        int a = r1.Next(1, 49);
        int col = 1 + (a / 10);
       // Response.Write(col + " " + a + ";");
        switch (col)
        {
            case 1:
                GridView1.Rows[gridrow].Cells[b].Style.Add("background-color", "#42A5F5");
                break;
            case 2:
                GridView1.Rows[gridrow].Cells[b].Style.Add("background-color", "#EC407A");
                break;
            case 3:
                GridView1.Rows[gridrow].Cells[b].Style.Add("background-color", "#ff9933");
                break;
            case 4:
                GridView1.Rows[gridrow].Cells[b].Style.Add("background-color", "#9575CD");
                break;
            case 5:
                GridView1.Rows[gridrow].Cells[b].Style.Add("background-color", "#FFEB3B");
                break;
            default:
                GridView1.Rows[gridrow].Cells[b].Style.Add("background-color", "#000");
                break;

        }
        GridView1.Rows[gridrow].Cells[b].Text = ("Ref no: " + transactab.Rows[bookrow].ItemArray[0] + "  " + " For: " + transactab.Rows[bookrow].ItemArray[5]).ToUpper();
        GridView1.Rows[gridrow].Cells[b].Style.Add("text-align", "center");
        GridView1.Rows[gridrow].Cells[b].Style.Add("border-radius", "6px");
        GridView1.Rows[gridrow].Cells[b].Style.Add("border", "1px solid #2288ff");
        GridView1.Rows[gridrow].Cells[b].Style.Add("width", "40px");
        GridView1.Rows[gridrow].Cells[b].Style.Add("text-color", "#ffffff ");
        //         Response.Write(GridView1.Rows[gridrow].Cells[b].Text + " " + 1 + "  " + dispmonth + out_month + "<BR />");

    }
    Random r2 = new Random();
    private void spanupto(DataTable transactab, int gridrow, int span1, int bookrow)
    {
        var tempj = 1;
        GridView1.Rows[gridrow].Cells[1].ColumnSpan += span1;
        for (int k = 1; k < span1; k++)
        {
            GridView1.Rows[gridrow].Cells[tempj + k].Visible = false;

        }
        
        int a = r2.Next(1, 49);
        int col = 1 + (a / 10);
       // Response.Write(col + " " + a + ";");
        switch (col)
        {
            case 1:
                GridView1.Rows[gridrow].Cells[1].Style.Add("background-color", "#42A5F5");
                break;
            case 2:
                GridView1.Rows[gridrow].Cells[1].Style.Add("background-color", "#EC407A");
                break;
            case 3:
                GridView1.Rows[gridrow].Cells[1].Style.Add("background-color", "#ff9933");
                break;
            case 4:
                GridView1.Rows[gridrow].Cells[1].Style.Add("background-color", "#FFEB3B");
                break;
            case 5:
                GridView1.Rows[gridrow].Cells[1].Style.Add("background-color", "#9575CD");
                break;
            default:
                GridView1.Rows[gridrow].Cells[1].Style.Add("background-color", "#000");
                break;

        }
        GridView1.Rows[gridrow].Cells[1].Text =  ("Ref no: " + transactab.Rows[bookrow].ItemArray[0] + "  " + " For: " + transactab.Rows[bookrow].ItemArray[5]).ToUpper();
        
        GridView1.Rows[gridrow].Cells[1].Style.Add("text-align", "center");
        GridView1.Rows[gridrow].Cells[1].Style.Add("border-radius", "6px");
        GridView1.Rows[gridrow].Cells[1].Style.Add("border", "1px solid #2288ff");

        GridView1.Rows[gridrow].Cells[1].Style.Add("text-color", "#ffffff");
        //  Response.Write(GridView1.Rows[gridrow].Cells[1].Text + " " + 3 + "<BR />");
    }
    Random r3 = new Random();
    private void totalspan(DataTable transactab, int gridrow, int span,int bookrow)
    {
        
        GridView1.Rows[gridrow].Cells[1].ColumnSpan += span;
        for (int k = 1; k < span; k++)
        {
            GridView1.Rows[gridrow].Cells[1 + k].Visible = false;

        }
       
        int a =r3.Next(1, 29);
        int col = 1+ (a/10);
      //  Response.Write(col + " " + a + ";" );
        switch (col)
        {
            case 1:
                GridView1.Rows[gridrow].Cells[1].Style.Add("background-color", "#42A5F5");
                break;
            case 2:
                GridView1.Rows[gridrow].Cells[1].Style.Add("background-color", "#EC407A");
                break;
            case 3:
                GridView1.Rows[gridrow].Cells[1].Style.Add("background-color", "#ff9933");
                break;
            default:
                GridView1.Rows[gridrow].Cells[1].Style.Add("background-color", "#000");
                break;

        }
        GridView1.Rows[gridrow].Cells[1].Text = ("Ref no: " + transactab.Rows[bookrow].ItemArray[0] + "  " + " For: " + transactab.Rows[bookrow].ItemArray[5]).ToUpper();
        
        GridView1.Rows[gridrow].Cells[1].Style.Add("text-align", "center");
        GridView1.Rows[gridrow].Cells[1].Style.Add("border-radius", "6px");
        GridView1.Rows[gridrow].Cells[1].Style.Add("border", "1px solid #2288ff");

        GridView1.Rows[gridrow].Cells[1].Style.Add("text-color", "#ffffff");
        //    Response.Write(GridView1.Rows[gridrow].Cells[1].Text + " " + 2 + "<BR />");
    }


    private void PopulateYear()
    {
        ddlYear.Items.Clear();
        ListItem lt = new ListItem();
        
        for (int i = DateTime.Now.Year + 2; i >= 2008; i--)
        {
            lt = new ListItem();
            lt.Text = i.ToString();
            lt.Value = i.ToString();
            ddlYear.Items.Add(lt);
        }
        ddlYear.Items.FindByValue(DateTime.Now.Year.ToString()).Selected = true;
    }

                                                           //Button ahead


    protected void Button1_Click(object sender, EventArgs e)
    {
        if (ddlMonth.SelectedValue == "1")
        {
            ddlMonth.SelectedIndex += 11;
            if (ddlYear.SelectedValue.ToString() == "2008")
            {

            }
            else
            {
                ddlYear.SelectedIndex++;

            }
        }
        else ddlMonth.SelectedIndex--;

        createtable(Convert.ToInt32(ddlMonth.SelectedValue), Convert.ToInt16(ddlYear.SelectedValue));
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (ddlMonth.SelectedValue == "12")
        {
            ddlMonth.SelectedIndex -= 11;
            ddlYear.SelectedIndex--;
        }
        else ddlMonth.SelectedIndex++;

        createtable(Convert.ToInt32(ddlMonth.SelectedValue), Convert.ToInt16(ddlYear.SelectedValue));
    }
    public void book_Click(object sender, EventArgs e)
    {
        string room = roomlist.SelectedItem.ToString();
       
        int count = 0;
        DateTime outn = Convert.ToDateTime(Request.QueryString["cout"].ToString());
        DateTime ino;
        DateTime inn = Convert.ToDateTime(Request.QueryString["cin"].ToString());
        DateTime outo;
        DataTable transactab = gettransactable();
        int bedcnt = 0;
        string roomno = roomlist.SelectedItem.ToString().Substring(0, 3);
        for (int ch = 0; ch <  transactab.Rows.Count; ch++)
        {
            if (transactab.Rows[ch].ItemArray[1].ToString() == roomno )
            {
                bedcnt = 0;
                if (room.Length == 9 && Convert.ToInt16(transactab.Rows[ch].ItemArray[6]) == 2) bedcnt++;
                else if (room.Length != 9 && Convert.ToInt16(transactab.Rows[ch].ItemArray[6]) == 1)
                {
                    bedcnt++;
                    
                    
                }
                if (bedcnt != 0)
                {
                    ino = Convert.ToDateTime(transactab.Rows[ch].ItemArray[2]);

                    if (outn >= ino)
                    {
                        outo = Convert.ToDateTime(transactab.Rows[ch].ItemArray[3]);
                        
                        if (inn <= outo)
                        {
                            
                            count++;
                            
                        }
                    }
                }
            }


        }
       
        if (count > 0)
        {
            string message = "Cannot Book " + roomno + "! Please select another room.";
            string script = "window.onload = function(){ alert('";
            script += message;
            script += "');";
            script += "}";
            ClientScript.RegisterStartupScript(this.GetType(), "Write", script, true);
            //Response.Write(script);
        }
        

        else if (room.Length == 9 && count == 0)
        {
            
            rb.insertintotrans(Convert.ToInt32(refno.Text), roomno, DateTime.Parse(cin.Text), DateTime.Parse(cout.Text), 2);
            rb.update_room_final_table(Convert.ToInt32(refno.Text), room);
            string message = "Room " + roomno + " Booked.";
            string url = "Dasboard.aspx";
            string script = "window.onload = function(){ alert('";
            script += message;
            script += "');";
            script += "window.location = '";
            script += url;
            script += "'; }";
            ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script, true);
        }
        else if (room.Length != 9 && count == 0)
        {
            
            rb.insertintotrans(Convert.ToInt32(refno.Text), room, DateTime.Parse(cin.Text), DateTime.Parse(cout.Text), 1);
            rb.update_room_final_table(Convert.ToInt32(refno.Text), room + ":1");
            string message = room + " Booked.";
            string url = "Dasboard.aspx";
            string script = "window.onload = function(){ alert('";
            script += message;
            script += "');";
            script += "window.location = '";
            script += url;
            script += "'; }";
            ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script, true);
        }
        
    }
    protected void check_Click(object sender, EventArgs e)
    {
        createtable(Convert.ToInt32(ddlMonth.SelectedValue), Convert.ToInt16(ddlYear.SelectedValue));
    }


}
