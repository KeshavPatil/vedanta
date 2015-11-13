<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PendReqPage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<link href="Styles/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class="container">
    <div align="center" class="page-header">
    <p class="h1">Guest Room-Lodging and Boarding</p>
    </div>
    <div align="center" class="container">
        
        <asp:GridView ID="appreqgrid" 
    runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
            BorderStyle="None" BorderWidth="1px" CellPadding="3">
    <Columns>
        <asp:BoundField DataField="Reference No" HeaderText="Reference No." 
            ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="Requester Name" HeaderText="Requester Name" 
            ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="Guest Name" HeaderText="Guest Name" 
            ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="Company Name" HeaderText="Company Name" 
            ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="Approver Name" HeaderText="Approver Name" 
            ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="Admin Name" HeaderText="Admin Name" 
            ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
        </asp:BoundField>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# string.Format("SodDetails.aspx?RefNo={0}&RequesterName={1}&GuestName={2}&CompanyName={3}&ApproverName={4}&AdminName={5}&vis=0",
                    HttpUtility.UrlEncode(Eval("Reference No").ToString()), HttpUtility.UrlEncode(Eval("Requester Name").ToString()), HttpUtility.UrlEncode(Eval("Guest Name").ToString()), HttpUtility.UrlEncode(Eval("Company Name").ToString()),HttpUtility.UrlEncode(Eval("Approver Name").ToString()),HttpUtility.UrlEncode(Eval("Admin Name").ToString())) %>'
                    Text="View Details" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
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
       <div align="center"><a href="GrandUnifiedLoggedIn.aspx"><span class="btn btn-primary">Home</span></a></div>
    </div>
    </form>
</body>
</html>
