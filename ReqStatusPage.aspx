<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReqStatusPage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="Styles/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class="container">
    <div align="center" class="page-header">
        <div style="float:right;">
            <asp:Label ID="user" runat="server"  ></asp:Label>
            <asp:LinkButton ID="linkGoSomewhere" runat="server" Click="logout_Click" 
                Text="(Logout)" onclick="logout_Click"/>
        </div>
        <p class="h1">Guest Room-Lodging and Boarding
        </p>
    </div>
    <div class="panel-body" align="center">
        <asp:GridView ID="statusgrid" runat="server" CellPadding="4" 
            ForeColor="#333333" GridLines="None" BorderStyle="Ridge" 
            AllowPaging="true" OnPageIndexChanging="statusgrid_PageIndexChanging">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerSettings Mode="NextPrevious" NextPageText=" Next" 
                PreviousPageText="Prev  " />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
         </div>
         <div align="center">
        <a href="GrandUnifiedLoggedIn.aspx"><span class="btn-primary btn-lg">Home</span></a>
        </div> 
    </form>
</body>
</html>
