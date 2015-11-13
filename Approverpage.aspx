<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Approverpage.aspx.cs" Inherits="Default3" %>

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
     <div class="container">
         <div class="center-block panel-body" align="center">
             <asp:GridView ID="shortdetails" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
                 RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000"
                 runat="server" AutoGenerateColumns="false">
                 <Columns>
                     <asp:BoundField DataField="Reference No" HeaderText="Reference No." ItemStyle-Width="150" />
                     <asp:BoundField DataField="Requester Name" HeaderText="Requester Name" ItemStyle-Width="150" />
                     <asp:BoundField DataField="Guest Name" HeaderText="Guest Name" ItemStyle-Width="150" />
                     <asp:BoundField DataField="Company Name" HeaderText="Company Name" ItemStyle-Width="150" />
                     <asp:TemplateField>
                         <ItemTemplate>
                             <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# string.Format("Details.aspx?RefNo={0}&RequesterName={1}&GuestName={2}&CompanyName=3",
                    HttpUtility.UrlEncode(Eval("Reference No").ToString()), HttpUtility.UrlEncode(Eval("Requester Name").ToString()), HttpUtility.UrlEncode(Eval("Guest Name").ToString()), HttpUtility.UrlEncode(Eval("Company Name").ToString())) %>'
                                 Text="View Details" />
                         </ItemTemplate>
                     </asp:TemplateField>
                 </Columns>
             </asp:GridView>
         </div>
        <div align="center">
        <a href="GrandUnifiedLoggedIn.aspx"><span class="btn btn-primary">Home</span></a>
    </div>
    </div>
    </form>
</body>
</html>
