<%@ Page Language="C#" AutoEventWireup="true" CodeFile="logreq.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="Styles/bootstrap.min.css" rel="stylesheet" type="text/css" />
<link href="Styles/StyleSheet1.css" rel="stylesheet" type="text/css" />
    <link href="Styles/timepicki.css" rel="stylesheet" type="text/css" />

    <title></title>
    <style type="text/css">
        .style2
        {
            height: 26px;
        }
    </style>
</head>
<body>
    <div class="container">
        <div class="col-md-2"></div>
        <div class="col-md-8 panel-body">
            <form id="form1" role="form" runat="server">
            
            <div id="form-group">
                <div align="center">
                    <font color="blue" face="verdana" size="6" class="h1">Guest Room-Lodging and Boarding</font>
                </div>
                <table class="table">
                    <tr>
                        <td>
                            <span class="h4">Guest Name</span>
                        </td>
                        <td>
                            <asp:TextBox ID="gname" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RfGuestName" runat="server" ControlToValidate="gname"
                                ErrorMessage="* Enter the name" Style="color: #CC3300" ValidationGroup="gr"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                         <span class="h4">SSL Employee</span>
                        </td>
                        <td>
                            <asp:DropDownList ID="sslemp" runat="server" CssClass="form-control" OnSelectedIndexChanged="gradelistchanged" AutoPostBack="true">
                                <asp:ListItem>Yes</asp:ListItem>
                                <asp:ListItem>Consultant</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                             <span class="h4">If SSL Employee(Grade)</span>
                        </td>
                        <td>
                            <asp:DropDownList ID="grade" runat="server" CssClass="form-control" >
                                <asp:ListItem></asp:ListItem>
                                <asp:ListItem>M1</asp:ListItem>
                                <asp:ListItem>M2</asp:ListItem>
                                <asp:ListItem>M3</asp:ListItem>
                                <asp:ListItem>M4</asp:ListItem>
                                <asp:ListItem>M5</asp:ListItem>
                                <asp:ListItem>M6</asp:ListItem>
                                <asp:ListItem>M7</asp:ListItem>
                                <asp:ListItem>M8</asp:ListItem>
                                <asp:ListItem>M9</asp:ListItem>
                            </asp:DropDownList>
                             

                        </td>
                    </tr>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
                    <tr>
                        <td>
                             <span class="h4">Company Name</span>
                        </td>
                        <td>
                            <asp:TextBox ID="company" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="company"
                                ErrorMessage="* company name" Style="color: #CC3300" ValidationGroup="gr"></asp:RequiredFieldValidator>

                        </td>
                    </tr>
                    <tr>
                        <td>
                             <span class="h4">Designation</span>
                        </td>
                        <td>
                            <asp:TextBox ID="designation" runat="server" CssClass="form-control"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>
                             <span class="h4">Contact No</span>
                        </td>
                        <td>
                            <asp:TextBox ID="contactno" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="contactno"
                                ErrorMessage="* contact number" Style="color: #CC3300" ValidationGroup="gr"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                ErrorMessage="* Enter correct contact no" Style="color: #CC3300"  ControlToValidate="contactno" ValidationExpression="[0-9]{10}" ValidationGroup="gr"></asp:RegularExpressionValidator>
                            
                        </td>
                    </tr>
                    <tr>
                        <td>
                             <span class="h4">Purpose</span>
                        </td>
                        <td>
                            <asp:TextBox ID="purpose" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ErrorMessage="Purpose required"  Style="color: #CC3300" ControlToValidate="purpose" ValidationGroup="gr"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                             <span class="h4">Check In</span>
                        </td>
                        <td>
                            
                         <asp:TextBox ID="checkin" runat="server" CssClass="form-control"></asp:TextBox>
                         
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Style="color: #CC3300" ErrorMessage="Required Field" ControlToValidate="checkin"></asp:RequiredFieldValidator>
                         
                        </td>
                    </tr>
                    <tr>
                        <td>
                             <span class="h4">Check Out</span>
                        </td>
                        <td>
                           
                          <asp:TextBox ID="checkout" runat="server" CssClass="form-control">
                          
                          </asp:TextBox>
                          <span class="glyphicon glyphicon-align-right glyphicon-book" </span>
                          
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Style="color: #CC3300" ErrorMessage="Required Field" ValidationGroup="gr" ControlToValidate="checkout"></asp:RequiredFieldValidator>
                    </tr>
                    <tr>
                        <td>
                             <span class="h4">Check in time</span>
                        </td>
                        <td>
                            <asp:TextBox ID="checkintime" runat="server" TextMode="Time"  CssClass="form-control" ></asp:TextBox>
                            
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Style="color: #CC3300" ErrorMessage="Required Field" ValidationGroup="gr" ControlToValidate="checkintime"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                             <span class="h4">Mode of arrival</span>
                        </td>
                        <td class="style2">
                            <asp:TextBox ID="mofarrival" runat="server" CssClass="form-control"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                             <span class="h4">Approved in PO</span>
                        </td>
                        <td>
                            
                                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal"
                                    CssClass="form-control">
                                    <asp:ListItem>Yes</asp:ListItem>
                                    <asp:ListItem>No</asp:ListItem>
                                </asp:RadioButtonList>
                           
                        </td>
                    </tr>
                    <tr>
                        <td>
                             <span class="h4">PO No.</span>
                        </td>
                        <td>
                            <asp:TextBox ID="pono" runat="server" CssClass="form-control"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                             <span class="h4">Stay Arrangement</span>
                        </td>
                        <td>
                            <asp:RadioButtonList ID="stayarr" runat="server" CssClass="form-control" RepeatDirection="Horizontal">
                                <asp:ListItem>Guest House</asp:ListItem>
                                <asp:ListItem>Trainee Hostel</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                             <span class="h4">Meal Arrangement</span>
                        </td>
                        <td>
                            <asp:RadioButtonList ID="mealarr" runat="server" CssClass="form-control" RepeatDirection="Horizontal">
                                <asp:ListItem>Guest House</asp:ListItem>
                                <asp:ListItem>Trainee Hostel</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                             <span class="h4">Mode of Payment</span>
                        </td>
                        <td>
                            <asp:RadioButtonList ID="mofpay" runat="server" CssClass="form-control" RepeatDirection="Horizontal">
                                <asp:ListItem>Bill to SSL</asp:ListItem>
                                <asp:ListItem>Self</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                             <span class="h4">Approving Authority</span>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server">
                                <asp:ListItem>HOD</asp:ListItem>
                                <asp:ListItem>Admin</asp:ListItem>
                                <asp:ListItem>Head</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </div>
            <p class="btn-group-lg">
                <a href="GrandUnifiedLoggedIn.aspx"><span class="btn-primary btn-lg">Home</span></a>
                <asp:Button ID="sub" runat="server" Text="Submit" OnClick="sub_Click" Style='float: right'
                    ValidationGroup="gr" CssClass="btn-success btn-lg" />
            </p>
            </form>
        </div>
    </div>
    
    <script src="Scripts/jquery-1.11.3.min.js" type="text/javascript"></script>
    <script src="bootstrap/js/bootstrap.min.js" type="text/javascript"></script>
    <script src="Scripts/bootstrap-datetimepicker.min.js" type="text/javascript"></script>
    <script src="Scripts/timepicki.js" type="text/javascript"></script>
    <script>
        $(document).ready(function () {

            $('#checkin').datepicker({
                format: "m/dd/yyyy"
            });
            $('#checkout').datepicker({
                format: "m/dd/yyyy"
            });
            $("#checkintime").timepicki();

        });
     </script>
</body>
</html>
