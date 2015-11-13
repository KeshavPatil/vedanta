<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dasboard.aspx.cs" Inherits="Dasboard" MasterPageFile="~/MasterPage1.master" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Dashboard</title>
    <link href="Styles/bootstrap.min.css" rel="stylesheet" type="text/css" />
   
    <link href="Styles/bootstrap-select.min.css" rel="stylesheet" type="text/css" />
     <link href="Styles/Dashboard.css" rel="stylesheet" type="text/css" />
    
</head>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <body>
    
    
                <div class="btn btn-primary" style="margin: 5px 0px 0px 5px;">
            <a ID="home" runat="server" href="GrandUnifiedLoggedIn.aspx" style="color: white; text-decoration: none;" >Home</a>
            </div>
                <div style="margin-top: 30px">
                    <asp:DropDownList ID="ddlMonth" CssClass="selectpicker col-md-1" style="margin: 0px 10px; color:Black" runat="server" >
                        <asp:ListItem Value="1">JAN</asp:ListItem>
                        <asp:ListItem Value="2">FEB</asp:ListItem>
                        <asp:ListItem Value="3">MAR</asp:ListItem>
                        <asp:ListItem Value="4">APR</asp:ListItem>
                        <asp:ListItem Value="5">MAY</asp:ListItem>
                        <asp:ListItem Value="6" >JUN</asp:ListItem>
                        <asp:ListItem Value="7">JUL</asp:ListItem>
                        <asp:ListItem Value="8">AUG</asp:ListItem>
                        <asp:ListItem Value="9">SEP</asp:ListItem>
                        <asp:ListItem Value="10">OCT</asp:ListItem>
                        <asp:ListItem Value="11">NOV</asp:ListItem>
                        <asp:ListItem Value="12">DEC</asp:ListItem>
                    </asp:DropDownList>
        
        
                    <asp:DropDownList ID="ddlYear" CssClass="selectpicker col-md-1" runat="server">
                    </asp:DropDownList>
                    <asp:Button ID="check" runat="server" onclick="check_Click" Text="Check" CssClass="btn btn-default"/>
                    
                    <div style="height: 60px; float: right; width: 50%; margin-bottom: 50px;">
                
                        <asp:Panel ID="Panel1" runat="server" Height="56px">
                            Ref. No:
                            <asp:Label ID="refno" runat="server" Text="Label"></asp:Label>
                            <br />
                            Checkin:
                            <asp:Label ID="cin" runat="server" Text="Label"></asp:Label>
                            <br />
                            Checkout:
                            <asp:Label ID="cout" runat="server" Text="Label"></asp:Label>
                            <br />
                            Grade:
                            <asp:Label ID="grade" runat="server" Text="Label"></asp:Label>
                            <div style="height: 30px; width: 300px; float: right; margin: -30px 20px 0px 0px;">
                                <asp:DropDownList ID="roomlist" CssClass="selectpicker" runat="server">
                                </asp:DropDownList>
                                <asp:Button ID="book" runat="server" onclick="book_Click" Text="Book" 
                                    CssClass=" btn-success  " />
                            </div>
                        </asp:Panel>
                
                
                    </div>
                    
                </div>
                <div style="height:30px"></div>
               
                <div   style="float:left; margin-left: 0px;">
                     <asp:ImageButton ID="Button1" runat="server" onclick="Button1_Click" ImageUrl="~/back_button.png" Width="100" Height="60"/>
                     <div style=" margin: -40px 0px 0px 54px">
                     <label runat="server" ID="backlab" style="font-family:Garamond Arial; color:White" class="text-capitalize"></label>
                     </div>
                </div>
                 <div   style="float:right; margin-right: -680px;">
                     <asp:ImageButton ID="Button2" runat="server" onclick="Button2_Click" ImageUrl="~/for_button.png" Width="100" Height="60"/>
                     <div style=" margin: -40px 0px 0px 17px"  >
                     <label runat="server" style="font-family:Garamond Arial; color:White" ID="forlab"></label>
                     </div>
                </div>
                 <div >
                    <div  style="margin-right:17px;" >
             
                        <asp:GridView ID="GridView2" runat="server" CssClass="header"  GridLines="None"  >
                      
                            <HeaderStyle CssClass="GVFixedHeader" BackColor="cadetblue" Font-Size="13px" Font-Names="Times New Roman, Times, serif"
                         BorderColor="CadetBlue"  BorderStyle=Solid BorderWidth="2px" HorizontalAlign="Center" VerticalAlign ="Middle"   />
                    
                        </asp:GridView>
              
                    </div>    
         
                    <div style="overflow:scroll; height: 518px">
                        <div  style=" height:500px; width: 100%;"  >
                            <asp:GridView ID="GridView1" runat="server"    
                            Font-Names="Times New Roman, Times, serif"
                            
                           >
                                <HeaderStyle CssClass="header1 "  />       
                    
                            </asp:GridView>

               
                        </div>
                    </div>
                </div>
        
    
    <script src="Scripts/jquery-1.11.3.min.js" type="text/javascript"></script>
    
    <script src="Scripts/bootstrap-select.min.js" type="text/javascript"></script>
    <script type="text/javascript">

        $(document).ready(function () {

            $(".selectpicker").selectpicker();

        });

</script>
   
</body>
</html>
</asp:Content>