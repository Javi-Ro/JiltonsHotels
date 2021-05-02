<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Packages.aspx.cs" Inherits="JiltonWeb.Packages" %>

<asp:Content ID="cssLink" ContentPlaceHolderID="cssLink" runat="server">
    <link rel="stylesheet" href="../css/packages.css?ver=<?php echo rand(155,999)?>" />
    <link href="https://fonts.googleapis.com/css2?family=IM+Fell+Double+Pica:ital@1&display=swap" rel="stylesheet">
    <style type="text/css">
      
    </style>

     <meta http-equiv="Expires" content="0">
    <meta http-equiv="Last-Modified" content="0">
    <meta http-equiv="Cache-Control" content="no-cache, mustrevalidate">
    <meta http-equiv="Pragma" content="no-cache">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     
    <div class="pack">
        
        <div class="image">
            <img src="assets/Placer.jpg" width="475" height="375" />
        </div>
        
        <div class ="desc">
            <h1> Placer</h1>

            <br /><br />

            <p> This package includes all you need to disconnect from the routine:<br />
                Daily massage (to choose)<br />
                Daily spa session<br />
            </p>

            <br />

            <p>Perfect experience for busy people</p>

        </div>
        <div class="overlay">
        <div class="text">BOOK NOW</div>
        </div>
    </div>

    
    <div class="pack">

        <div class="image">
            <img src="assets/Familia.jpg" width="475" height="375" />
        </div>
        
        <div class ="desc">
            <h1> Family</h1>

            <br /><br />

            <p> All needed to have a unique experience:<br />
                Daily trip<br />
                Camping trips every 2 days<br />
            </p>

            <br />

            <p>Perfect for families and groups</p>

        </div>

        <div class="overlay">
        <div class="text">BOOK NOW</div>
        </div>
    </div>

    <div class="pack">
        
        <div class="image">
            <img src="assets/Para2.jpg" width="475" height="375" />
        </div>
        
        <div class ="desc">
            <h1> Couple</h1>

            <br /><br />

            <p> This package includes a perfect couple experience:<br />
                Daily spa session for both<br />
                A trip to spend the night in a beautiful remote villa<br />
                A deluxe romantic dinner in the restaurant
            </p>

            <br />

            <p>Perfect experience for couples</p>
            
        </div>
        <div class="overlay">
        <div class="text">BOOK NOW</div>
        </div>
    </div>

    <div class="pack">

        <div class="image">
            <img src="assets/coches.jpg" width="475" height="375" />
        </div>
        
        <div class ="desc">
            <h1> Car</h1>

            <br /><br />

            <p> Includes the best experience for in-love-with-cars people:
                You will be able to choose the car you want from our collection every 2 days, to spend the day with it. 
                And a special day, you will be invited to a profesional circuit with a car you choose.
            </p>

            <br />

            <p>Perfect if you love cars</p>

         
            
        </div>
        <div class="overlay">
        <div class="text">BOOK NOW</div>
        </div>
    </div>-->
</asp:Content>
