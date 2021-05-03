<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Packages.aspx.cs" Inherits="JiltonWeb.Packages" %>

<asp:Content ID="cssLink" ContentPlaceHolderID="cssLink" runat="server">
    <link rel="stylesheet" href="../css/packages.css?ver=<?php echo rand(154,999)?>" />
    <link href="https://fonts.googleapis.com/css2?family=IM+Fell+Double+Pica:ital@1&display=swap" rel="stylesheet">
    <style type="text/css">
      
    </style>

     <meta http-equiv="Expires" content="0">
    <meta http-equiv="Last-Modified" content="0">
    <meta http-equiv="Cache-Control" content="no-cache, mustrevalidate">
    <meta http-equiv="Pragma" content="no-cache">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     
    <div class="pack" >

        <div class="image">
            <img src="assets/spa.jpg" style="width: 100%; height: 100%; object-fit: cover;"/>
        </div>

        <a href="#" style="color: black;">
        <div class="overlay">
        <div class="text">
            <h1> Pleasure Pack</h1>

            <br />

            <p> This package includes all you need to disconnect from the routine:<br />
                Daily massage (to choose)<br />
                Daily spa session<br />
            </p>

            <br />

            <p>Perfect experience for busy people</p>
        </div>
        </div>
        </a>
        
       
    </div>

    
    <div class="pack" >

        <div class="image">
            <img src="assets/couple.jpg" style="width: 100%; height: 100%; object-fit: cover;"/>
        </div>

        <a href="#" style="color: black;">
        <div class="overlay">
        <div class="text">
            <h1> 
                Couple Pack
            </h1>

            <br />

            <p> This package includes a perfect couple experience:<br />
                Daily spa session for both<br />
                A trip to spend the night in a beautiful remote villa<br />
                A deluxe romantic dinner in the restaurant
            </p>

            <br />

            <p>Perfect experience for couples</p>
        </div>
        </div>
        </a>

        
    </div>

    <div class="pack" >

        <div class="image">
            <img src="assets/trip.jpg" style="width: 100%; height: 100%; object-fit: cover;"/>
        </div>

        <a href="#" style="color: black;" >
        <div class="overlay">
        <div class="text">
            <h1> Adventure Pack</h1>

            <br />

            <p> All needed to have a unique experience:<br />
                Daily trip<br />
                Camping trips every 2 days<br />
            </p>

            <br />

            <p>Perfect for families and groups</p>
        </div>
        </div>
            </a>
       
    </div>

    <div class="pack">

        <div class="image">
            <img src="assets/cars.jpg" style="width: 100%; height: 100%; object-fit: cover;"/>
        </div>

        <a href="#" style="color: black;">
        <div class="overlay">
        <div class="text">
            <h1> Supercar Pack</h1>

            <br />

            <p> Includes the best experience for in-love-with-cars people. You will be able to choose the car you want from our collection every 2 days, to spend the day with it. 
                And a special day, you will be invited to a profesional circuit with a car you choose.
            </p>

            <br />

            <p>Perfect if you love cars</p>
        </div>
        </div>
        </a>

    </div>
</asp:Content>
