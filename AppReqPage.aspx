<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppReqPage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="Styles/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body >
   
        <form id="form1" runat="server" class="container">
        <div align="center" class="page-header">
            <p class="h1">Guest Room-Lodging and Boarding</p>
        </div>
        <div align="center" class="panel-body">
            
                <asp:GridView ID="appreqgrid" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
                    RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000"
                    runat="server" AutoGenerateColumns="False" CellPadding="4" 
                    ForeColor="#333333" GridLines="None">
<AlternatingRowStyle BackColor="White" ForeColor="#284775"></AlternatingRowStyle>
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
                                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# string.Format("SodDetails.aspx?RefNo={0}&RequesterName={1}&GuestName={2}&CompanyName={3}&ApproverName={4}&AdminName={5}",
                    HttpUtility.UrlEncode(Eval("Reference No").ToString()), HttpUtility.UrlEncode(Eval("Requester Name").ToString()), HttpUtility.UrlEncode(Eval("Guest Name").ToString()), HttpUtility.UrlEncode(Eval("Company Name").ToString()),HttpUtility.UrlEncode(Eval("Approver Name").ToString()),HttpUtility.UrlEncode(Eval("Admin Name").ToString())) %>'
                                    Text="View Details" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />

<HeaderStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True"></HeaderStyle>

                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />

<RowStyle BackColor="#F7F6F3" ForeColor="#333333"></RowStyle>
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
                    </div>
                    <div align="center"><a href="GrandUnifiedLoggedIn.aspx"><span class="btn btn-primary">Home</span></a></div>
        </form>
    
</body>
</html>
