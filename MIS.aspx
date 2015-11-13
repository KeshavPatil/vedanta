<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MIS.aspx.cs" Inherits="MIS" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
    <title>MIS</title>
    <link href="Styles/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="Styles/bootstrap-datetimepicker.min.css" rel="stylesheet" type="text/css" />
   
    
    <style>
        .header
        {
            border: 2px solid white;
        }
    
    </style>
    
</head>
<body>
    <form id="form1" runat="server" class="container">
    <div>
    
    </div>
    <div align="center" class="page-header">
    <p class="h1">Guest Room-Lodging and Boarding</p>
    </div>
    <div class="container">
            <div style="float:left"><a href="GrandUnifiedLoggedIn.aspx"><span class="btn btn-primary">Home</span></a>
            </div>
            <%--<div class="form-group" style="float: right;" >
                 <div class="hero-unit" style="float: right; margin: 20px">
                    End Date:
                    <asp:TextBox runat="server" ID="end" CssClass="form-control"></asp:TextBox>
                </div>   
                 <div class="hero-unit"  style="float: right;  margin:  20px">
                    Start Date:
                    <asp:TextBox runat="server" ID="start" CssClass="form-control"></asp:TextBox>
                </div>
            </div>--%>
                    
        
            </div>
            
            <div align="center" class="col-lg-12">
            <asp:GridView ID="misgrid" runat="server" CellPadding="4" ForeColor="#333333" 
                     BorderStyle="Ridge" AllowPaging="true" OnPageIndexChanging="misgrid_PageIndexChanging" >
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" CssClass="header" />
                <PagerSettings Mode="NextPrevious" NextPageText="Next" 
                    PreviousPageText="Prev" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
           </div>
    
        
    </form>
    <script src="jquery-2.1.4.min.js" type="text/javascript"></script> 
    
    <script src="bootstrap/js/bootstrap.min.js" type="text/javascript"></script>
    <script src="Scripts/bootstrap-datetimepicker.min.js" type="text/javascript"></script>
    <script>
        $(document).ready(function () {

            $('#start').datepicker({
                format: "m/dd/yyyy"
            });
            $('#end').datepicker({
                format: "m/dd/yyyy"
            });
           
        });
     </script>


</body>
</html>
