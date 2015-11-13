<%@ Page Language="C#" AutoEventWireup="true" CodeFile="checkoutbill.aspx.cs" Inherits="checkoutbill" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<link href="Styles/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <title>Guest Check Out</title>
</head>
<body>
    <form id="form1" runat="server" class="container">
    <div align="center" class="page-header">
    <p class="h1">Guest Room-Lodging and Boarding</p>
    </div>
 
    <div class="col-lg-4">
        <ul class="nav nav-stacked" id="sidebar">
                <li class="h4">Name:<asp:Label ID="name" runat="server" Text="Label" ></asp:Label></li>
                <li class="h4">Company Name:<asp:Label ID="company" runat="server" Text="Label"></asp:Label></li>
                <li class="h4">Check In:<asp:Label ID="cin" runat="server" Text="Label"></asp:Label></li>
                <li class="h4">Check Out:<asp:Label ID="cout" runat="server" Text="Label"></asp:Label></li>
                <li class="h4">Room No:<asp:Label ID="room" runat="server" Text="Label"></asp:Label></li>
        </ul>
         <div class="h3">
        Total:<asp:Label ID="billtotal" runat="server" Text="0"></asp:Label><br />
        <asp:Button ID="export" runat="server" onclick="export_Click" 
            Text="Export to Excel" CssClass="btn btn-primary"/>
        <asp:Button ID="Checkout" runat="server" onclick="Checkout_Click" 
            Text="Checkout" CssClass="btn btn-success" />
            <a href="checkout.aspx"><span class=" btn btn-warning">Back</span></a>
            </div>
    </div>
    <div align="center" class="col-lg-6 panel-body">
    
        <asp:GridView ID="bill" runat="server" BackColor="White" BorderColor="#CCCCCC" 
            BorderStyle="None" BorderWidth="1px" CellPadding="3">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        </div>
        <div class="col-lg-2"></div>
       
    
    </form>
</body>
</html>
