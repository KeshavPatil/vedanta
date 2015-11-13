<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="Styles/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" class="page-header">
    <p class="h1">Guest Room-Lodging and Boarding</p>
    </div>
    <div class="container">
        <p align="Left"><a href="Approverpage.aspx">Back</a></p>
        <div class="col-lg-8">
            <table class="table">
                <tr>
                    <td>
                        Guest Name
                    </td>
                    <td>
                        <asp:Label ID="gname" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Company Name
                    </td>
                    <td>
                        <asp:Label ID="cname" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Designation
                    </td>
                    <td>
                        <asp:Label ID="dname" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Contact No.
                    </td>
                    <td>
                        <asp:Label ID="contno" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Purpose
                    </td>
                    <td>
                        <asp:Label ID="purpose" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Check In
                    </td>
                    <td>
                        <asp:Label ID="checkin" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Check Out
                    </td>
                    <td>
                        <asp:Label ID="checkout" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Stay Arrangement
                    </td>
                    <td>
                        <asp:Label ID="stayarr" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Meal Arrangement
                    </td>
                    <td>
                        <asp:Label ID="mealarr" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Mode of Payment
                    </td>
                    <td>
                        <asp:Label ID="mofpay" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
       
   
    
        <%--<table class="table">
            <tr>
                <td colspan="2">
                    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
                       Height="50px" Width="100%" BackColor="White" BorderColor="#CCCCCC" 
                        BorderStyle="None" BorderWidth="1px" CellPadding="3">
                        <EditRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        <Fields>
                            <asp:BoundField DataField="Reference_No" HeaderText="Reference_No" 
                                SortExpression="Reference_No" />
                            <asp:BoundField DataField="Guest_Name" HeaderText="Guest_Name" 
                                SortExpression="Guest_Name" />
                            <asp:BoundField DataField="Company_Name" HeaderText="Company_Name" 
                                SortExpression="Company_Name" />
                            <asp:BoundField DataField="Designation" HeaderText="Designation" 
                                SortExpression="Designation" />
                      
                            <asp:BoundField DataField="Purpose" HeaderText="Purpose" 
                                SortExpression="Purpose" />
                            <asp:BoundField DataField="Check_In" HeaderText="Check_In" 
                                SortExpression="Check_In" />
                            <asp:BoundField DataField="Check_Out" HeaderText="Check_Out" 
                                SortExpression="Check_Out" />
                            <asp:BoundField DataField="Stay_arrangement" HeaderText="Stay_arrangement" 
                                SortExpression="Stay_arrangement" />
                            <asp:BoundField DataField="Meal_arrangement" HeaderText="Meal_arrangement" 
                                SortExpression="Meal_arrangement" />
                            <asp:BoundField DataField="Mode_of_payment" HeaderText="Mode_of_payment" 
                                SortExpression="Mode_of_payment" />
                        </Fields>
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                        <RowStyle ForeColor="#000066" />
                    </asp:DetailsView>
                </td>
            </tr>--%>
            <tr>
                <td>
                    <asp:Button ID="accept" runat="server" onclick="accept_Click" Text="Accept"  CssClass="btn btn-success"/>
                </td>
                <td>
                    <asp:Button ID="reject" runat="server" onclick="reject_Click" Text="Reject" CssClass="btn btn-danger" />
                </td>
            </tr>
        </table>
     </div >
    </div>
    </form>
    
</body>
</html>
