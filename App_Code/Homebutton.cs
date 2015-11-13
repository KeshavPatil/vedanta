using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Homebutton
{
    public Homebutton()
	{
	}

    public string rethomepage(string db)
    {
        int i = int.Parse(db);
        if (i==0)
            return "userin.aspx";
        else if (i==1)
            return "hodpage.aspx";
        else if (i==2)
            return "adminpage.aspx";
        else
            return "sodexo.aspx";
    }
}