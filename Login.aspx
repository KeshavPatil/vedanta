<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Login"%>


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
        .botn
        {
            background-color:Blue;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" role="form" class="container">
    <div align="center" class="page-header">
    <p class="h1">Guest Room-Lodging and Boarding</p>
    </div>
       
    <div class="container">
   
    <div class="col-lg-4">
     <div class="text-center text-primary h3 ">
           USER LOGIN            
        </div>
        <ul class="list-group">
            <li class="list-group-item">
                <p style="font-family:@Arial Unicode MS;font-size:large">User ID</p>
                <asp:TextBox ID="userid" runat="server" CssClass="form-control"></asp:TextBox><asp:RequiredFieldValidator
                    ID="RequiredFieldValidator1" runat="server" ErrorMessage="*User ID Required" ControlToValidate="userid" CssClass="label label-danger"></asp:RequiredFieldValidator></li>
            <li class="list-group-item">
                <p style="font-family:@Arial Unicode MS;font-size:large">Password</p>
                <asp:TextBox ID="pass" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox><asp:RequiredFieldValidator
                    ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Please enter Password" ControlToValidate="pass" CssClass="label label-danger"></asp:RequiredFieldValidator></li>
            </ul>
                <asp:Button ID="login" runat="server" Text="Login" OnClick="login_Click" CssClass="btn btn-primary btn-lg" />
           </div>
            <div class="col-lg-8"></div>
           </div>
    </form>
</body>
</html>
