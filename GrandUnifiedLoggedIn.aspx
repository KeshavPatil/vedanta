<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GrandUnifiedLoggedIn.aspx.cs" Inherits="GrandUnifiedLoggedIn" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title></title>
    <link href="Styles/bootstrap.min.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" class="container">
    <div align="center" class="page-header">
    <h1>Guest House Lodging and Boarding</h1>
    </div>
    <div style="float:right;">
            <asp:Label ID="user" runat="server"  ></asp:Label>
            <asp:LinkButton ID="linkGoSomewhere" runat="server" Click="logout_Click" 
                Text="(Logout)" onclick="logout_Click"/>
        </div>
    <div class="container">
        <div class="col-md-10">
            
            
            <ul class="nav nav-pills nav-stacked">
                <li class="h3">
                    <asp:Panel ID="logreq" runat="server" Visible="False" >
                        <div style="background-color: #00BCD4; width: 150px; height: 150px; box-shadow: 10px 10px 10px #999;  float: left; padding:20px 25px ; margin-right: 10px; margin-left: 10px; font-weight: bolder; color: #FFFFFF; font-family: Verdana; font-size: 20px">
                        <a href="logreq.aspx" style="color:White; text-decoration: none; padding:10px 50px 40px 50px ;"><span class="glyphicon glyphicon-arrow-right"></span>Request For Room</a>
                        </div>
                    </asp:Panel>
                </li>
                <li class="h3">
                    
                    <asp:Panel ID="reqstat" runat="server" Visible="False">
                        <div style=" background-color: #00BCD4; width: 150px; height: 150px; box-shadow: 10px 10px 10px #999; padding:20px 25px ; float: left; margin-right: 10px; margin-left: 10px; font-weight: bolder; color: #FFFFFF; font-family: Verdana; font-size: 20px">
                        <a href="ReqStatusPage.aspx" style="color:White; text-decoration:none; padding:10px 50px  30px 50px"><span class="glyphicon glyphicon-arrow-right"></span>Check Request Status</a>
                        </div>
                    </asp:Panel>
                    
                </li>
                <li class="h3">
                    
                    <asp:Panel ID="pendreq" runat="server" Visible="False">
                        <div style= "background-color: #00BCD4; width: 150px; height: 150px; box-shadow: 10px 10px 10px #999; padding:30px 25px ; float: left; margin-right: 10px; margin-left: 10px; font-weight: bolder; color: #FFFFFF; font-family: Verdana; font-size: 20px">
                        <a href="Approverpage.aspx" style="color:White; text-decoration: none; padding:10px 10px 35px 10px "><span class="glyphicon glyphicon-arrow-right"></span>Pending Requests</a>
                        </div>
                    </asp:Panel>
                    
                </li>
                <li class="h3">
                    
                    <asp:Panel ID="dashboard" runat="server" Visible="False">
                        <div style= "background-color: #00BCD4; width: 170px; height: 150px; box-shadow: 10px 10px 10px #999; padding:40px 25px ; float: left; margin-right: 10px; margin-left: 10px; font-weight: bolder; color: #FFFFFF; font-family: Verdana; font-size: 20px">
                        <a href="Dasboard.aspx" style="color:White; text-decoration: none; padding:10px 10px 35px 10px "><span class="glyphicon glyphicon-arrow-right"></span>Dashboard</a>
                        </div>
                    </asp:Panel>
                    
                </li>
                <li class="h3">
                    <asp:Panel ID="sodexo" runat="server" Visible="False" CssClass="panel-body">
                        <div class="servicehead" style= "background-color: #00BCD4; background-image:url('images.png');  width: 150px; height: 150px; box-shadow: 10px 10px 10px #999; padding:40px 15px ; float: left; margin-right: 10px; margin-left: 10px; font-weight: bolder; color: #FFFFFF; font-family: Verdana; font-size: 20px">
                            <p style="color:White; text-decoration: none; padding:10px 10px 35px 10px ">Service Provider</p>
                        </div>    
                        <div style= "background-color: #00BCD4; width: 150px; height: 150px; box-shadow: 10px 10px 10px  #999; padding:40px 25px ; float: left; margin-right: 10px; margin-left: 10px; font-weight: bolder; color: #FFFFFF; font-family: Verdana; font-size: 20px">
                        <a href="checkout.aspx" style="color:White; text-decoration: none; padding:10px 10px 35px 10px "><span class="glyphicon glyphicon-arrow-right"></span>Checkout</a><br />
                        </div>
                        <div id="das" style= "background-color: #00BCD4; width: 170px; height: 150px; box-shadow: 10px 10px 10px #999; padding:40px 25px ; float: left; margin-right: 10px; margin-left: 10px; font-weight: bolder; color: #FFFFFF; font-family: Verdana; font-size: 20px">
                        <a href="Dasboard.aspx" style="color:White; text-decoration: none; padding:10px 10px 35px 10px "><span class="glyphicon glyphicon-arrow-right"></span>Dashboard</a><br />
                        </div>
                        <div style= "background-color: #00BCD4; width: 150px; height: 150px; box-shadow: 10px 10px 10px #999; padding:40px 50px ; float: left; margin-right: 10px; margin-left: 10px; font-weight: bolder; color: #FFFFFF; font-family: Verdana; font-size: 20px">
                        <a href="MIS.aspx" style="color:White; text-decoration: none; padding:30px 10px 35px 10px "><span class="glyphicon glyphicon-arrow-right"></span>MIS</a><br />
                        </div>
                        <div style="width: 150px; height: 150px;"></div>
                        <div class="service"  >
                            <div class="col-md-12" style="height: 30px;"></div>
                            <div class="ani" style= "background-color: #009688; width: 150px; height: 150px; box-shadow: 10px 10px 10px #999; padding:50px 20px ; float: left; margin-right: 10px; margin-left: 10px; font-weight: bolder; color: #FFFFFF; font-family: Verdana; font-size: 20px">
                                <a href="AppReqPage.aspx" style="color:White; text-decoration: none; padding:30px 10px 35px 0px ">Approved Requests</a>
                             </div>
                             <div class="ani" style= "background-color: #009688; width: 150px; height: 150px; box-shadow: 10px 10px 10px #999; padding:50px 20px ; float: left; margin-right: 10px; margin-left: 10px; font-weight: bolder; color: #FFFFFF; font-family: Verdana; font-size: 20px">
                                <a href="PendReqPage.aspx" style="color:White; text-decoration: none; padding:30px 10px 35px 0px ">Pending Requests</a> 
                             </div>
                             <div class="ani" style= "background-color: #009688; width: 150px; height: 150px; box-shadow: 10px 10px 10px #999; padding:50px 40px ; float: left; margin-right: 10px; margin-left: 10px; font-weight: bolder; color: #FFFFFF; font-family: Verdana; font-size: 20px">               
                                <a href="foodtest.aspx" style="color:White; text-decoration: none; padding:30px 10px 35px 0px " >Food Billing</a> 
                             </div> 
                         </div>
                      </asp:Panel>
                  </li>
                </ul>
                
            
        </div>

    </div>
    <div align="center" style="margin: 100px"><asp:Button ID="Button1" runat="server" onclick="logout_Click" Text="logout" CssClass="btn btn-danger"/></div>
    <h2><asp:Label ID="login" runat="server" Visible="false"  ></asp:Label></h2>
    <div align="center" style="margin: 100px"><h2><asp:Button ID="Button2" runat="server" onclick="login_Click" Text="Login" CssClass="btn btn-success" Visible ="false" /></h2></div>
    </form>
    <script src="Scripts/jquery-1.11.3.min.js" type="text/javascript"></script>
    <script>
        $(document).ready(function () {
           
            var fadedin = false;
            $(".service").toggle();
             $("#das").click(function(){
               
                $(this).animate({
                   height: '+=20px'
                    }, 30);
            });
            $("#das").dblclick(function(){
               
                $(this).animate({
                   height: '-=60px'
                    }, 30);
            });
            $(".servicehead").mouseenter(function () {
                 
                $(".service").fadeIn("fast");
                fadedin = true;
                $(".ani").animate({
                    height: '+=4px',
                    width: '+=4px',
                    }, "fast");
                $(".ani").animate({
                    height: '-=4px',
                    width: '-=4px',
                    }, "fast");


            });
            $(".servicehead").mouseleave(function (e) {
                var $this = $(this);

                var bottom = $this.offset().top + $this.outerHeight();

                if (e.pageY >= bottom);
                else{
                    $(".service").fadeOut("slow");
                    fadedin = false;
                    }

            });

            $(".service").mouseenter(function () {
                if (!fadedin)
                {
                    $(".service").fadeIn("fast");
                    fadedin = true;
                }
            });
            $(".service").mouseleave(function (e) {
                var $service = $(".service");

                var bottom = $service.offset().top - $service.outerHeight();

                if (e.pageY <= bottom);
                else if (fadedin)
                {   
                    
                    $(".service").fadeOut("slow");
                    fadedin = false;
                }


            });
             

            
        });

    
    
    </script>
</body>
</html>
