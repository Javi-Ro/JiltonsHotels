<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThanksForBuy.aspx.cs" Inherits="JiltonWeb.ThanksForBuy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"> 
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="../css/thank.css?ver=<?php echo rand(105,999)?>" />
    <title> JiltonHotel </title> 
</head>
<body>
    <form id="form1" runat="server">
        <div class="ult">
        <div class="total">
            <div class="todo">
                <br />
                <div class="img">
                    <img src="../assets/jiltonLogo2.png" class="imagen" />
                </div>
                <br />
                <h1 class="titulo">THANK YOU FOR YOUR BOOKING!</h1>
                <br />
                <div class="img">
                    <img src="../assets/tick2.png" class="imagen"/>
                </div>
                <h1 class="HotelName">JILTON HOTEL RESORT & SPA CENTER</h1>
                <br />
                
                <br />
                <h3 class="war">A 5% of the money you spent on our services will be delivered to companies to help war refugees in Syria.</h3>                
                <br />
                <br />
                <div class="but">
                    <asp:Button runat="server" Text="BACK TO MAIN PAGE" ID="boton1" OnClick="Boton" CssClass="botonya"/>
                </div>
                
            </div>
        </div>
      </div>

    </form>
</body>
</html>
