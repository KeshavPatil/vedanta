<%@ Page Language="C#" AutoEventWireup="true" CodeFile="checkout.aspx.cs" Inherits="checkout" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="Styles/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class="container">
    <div align="center" class="page-header">
    <p class="h1" 
            style="text-transform: uppercase; font-family: Garamond; font-weight: bold;">Guest CheckOut</p>
    </div>
    <div align="center" class="panel-body">
    <asp:GridView ID="shortdetails" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
    RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000"
    runat="server" AutoGenerateColumns="false" 
    AllowPaging="true" OnPageIndexChanging="shortdetails_PageIndexChanging"
    >
<AlternatingRowStyle BackColor="White" ForeColor="#000000"></AlternatingRowStyle>
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
        <asp:BoundField DataField="Check In" HeaderText="Check In" 
            ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="Check Out" HeaderText="Check Out" 
            ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="Room No" HeaderText="Room No" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
        </asp:BoundField>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# string.Format("checkoutBill.aspx?RefNo={0}&RequesterName={1}&GuestName={2}&CompanyName={3}&cin={4}&cout={5}&roomno={6}",
                    HttpUtility.UrlEncode(Eval("Reference No").ToString()), HttpUtility.UrlEncode(Eval("Requester Name").ToString()), HttpUtility.UrlEncode(Eval("Guest Name").ToString()), HttpUtility.UrlEncode(Eval("Company Name").ToString()), HttpUtility.UrlEncode(Eval("Check In").ToString()), HttpUtility.UrlEncode(Eval("Check Out").ToString()), HttpUtility.UrlEncode(Eval("Room No").ToString())) %>'
                    Text="Check Out" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>

<HeaderStyle BackColor="#3AC0F2" ForeColor="White"></HeaderStyle>

        <PagerSettings Mode="NextPreviousFirstLast" NextPageText="Next" 
            PreviousPageText="Prev" />

<RowStyle BackColor="#A1DCF2"></RowStyle>
</asp:GridView>
    </div>
    <div align="center">
    <a href="GrandUnifiedLoggedIn.aspx"><span class="btn-lg btn-warning">Back</span></a>
    </div>
    </form>
</body>
</html>
