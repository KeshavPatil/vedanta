<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SodDetails.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="Styles/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
     <form id="form1" runat="server" class="container">
    <div align="center" class="page-header">
    <p class="h1">Guest Room-Lodging and Boarding</p>
        
    </div>
     <div class="container">
         <div class="btn btn-primary" style="margin: 20px; color:White; float:left">
            <a runat="server" href="GrandUnifiedLoggedIn.aspx"  style=" color:White;">Home</a>
            </div>
         <div class="col-md-4">
         </div>
         <div align="center">
             <table class="table">
                 <tr>
                     <td>
                        <span class="text-info" style="font-size:large;font-family:Times New Roman"> Guest Name</span>
                     </td>
                     <td>
                         <asp:Label ID="gname" runat="server" Text="Label" class="h4"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td>
                       <span class="text-info" style="font-size:large;font-family:Times New Roman">Company Name</span>
                     </td>
                     <td>
                         <asp:Label ID="cname" runat="server" Text="Label" class="h4"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td>
                        <span class="text-info" style="font-size:large;font-family:Times New Roman"> Designation</span>
                     </td>
                     <td>
                         <asp:Label ID="dname" runat="server" Text="Label" class="h4"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td>
                         <span class="text-info" style="font-size:large;font-family:Times New Roman">Contact No.</span>
                     </td>
                     <td>
                         <asp:Label ID="contno" runat="server" Text="Label" class="h4"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td>
                        <span class="text-info" style="font-size:large;font-family:Times New Roman"> Grade</span>
                     </td>
                     <td>
                         <asp:Label ID="grade" runat="server" Text="Label" class="h4"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td>
                         <span class="text-info" style="font-size:large;font-family:Times New Roman">Check In</span>
                     </td>
                     <td>
                         <asp:Label ID="checkin" runat="server" Text="Label" class="h4"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td>
                        <span class="text-info" style="font-size:large;font-family:Times New Roman"> Check Out</span>
                     </td>
                     <td>
                         <asp:Label ID="checkout" runat="server" Text="Label" class="h4"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td>
                         <span class="text-info" style="font-size:large;font-family:Times New Roman">Stay Arrangement</span>
                     </td>
                     <td>
                         <asp:Label ID="stayarr" runat="server" Text="Label" class="h4"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td>
                        <span class="text-info" style="font-size:large;font-family:Times New Roman"> Meal Arrangement</span>
                     </td>
                     <td>
                         <asp:Label ID="mealarr" runat="server" Text="Label" class="h4"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td>
                        <span class="text-info" style="font-size:large;font-family:Times New Roman">Mode of Payment</span>
                     </td>
                     <td>
                         <asp:Label ID="mofpay" runat="server" Text="Label" class="h4"></asp:Label>
                     </td>
                 </tr>
             </table>
         </div>
         <div  align="center">
             <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                 Text="Book Room" CssClass="btn btn-danger"/></div>
         <div class="col-lg-4">
             
         </div>
        </div>
    </form>
</body>
</html>
