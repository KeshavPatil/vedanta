<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
    <div>
    
        Insert page not accessible via any link</div>
    <table class="style1">
        <tr>
            <td>
                Username</td>
            <td>
                <asp:TextBox ID="usname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Password</td>
            <td>
                <asp:TextBox ID="passw" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Retype Password</td>
            <td>
                <asp:TextBox ID="repass" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
    </table>
    <p align="right">
    <asp:Button ID="sub" runat="server" Text="Submit" onclick="sub_Click" />
    </p>
    </form>
</body>
</html>
