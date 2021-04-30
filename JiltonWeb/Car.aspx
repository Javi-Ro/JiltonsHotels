<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Car.aspx.cs" Inherits="JiltonWeb.Car" %>
<asp:Content ID="TitleForm" ContentPlaceHolderID="cssLink" runat="server">
        <link rel="stylesheet" href="../css/car.css?ver=<?php echo rand(143,999)?>" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="car">

        <div class="foto">
            <img src="assets/coche_1.jpg" width="475" height="375" />
        </div>
        
        <div class ="texto">
            <h1> Mercedes S63 AMG</h1>

            <br />

            <p> Making use of a 4.0-liter bi-turbo V8 engine with 603 hp and 664 lb-ft of torque, the S63 will blast to 60 mph in only 3.5 seconds. 
                A nine-speed AMG automatic transmission, 4Matic+ all-wheel-drive, and an adaptive sport suspension are standard. </p>

            <br /><br />

            <p>We would be pleased of letting our guesses try this awesome german machine!</p>

            
            <div class="reservaBoton">
               <p> RESERVE NOW </p>
            </div>

            
        </div>
    </div>

    
    <div class="car">

        <div class="foto">
            <img src="assets/coche_2.jpg" width="475" height="375"/>
        </div>

        <div class ="texto">
            <h1> Tesla Roadster </h1>

            <br />

            <p> The Tesla Roadster is an all-electric battery-powered four-seater sports car concept in development by Tesla, Inc.
                Tesla has claimed that it will be capable of 0 to 60 mph (0 to 97 km/h) in 1.9 seconds, which would be quicker 
                than any street legal production. This model is not for sale yet. </p>

            <br /><br />

            <p>We would be pleased of letting our guesses try this exclusive new Tesla in advance!</p>

            <div class="reservaBoton">
               <p> RESERVE NOW </p>
            </div>

        </div>
        
    </div>

    <div class="car">

        <div class="foto">
            <img src="assets/coche_3.jpg" width="475" height="375"/>
        </div>

        <div class ="texto">
            <h1> Rolls-Royce Phantom </h1>

            <br />

            <p> This exclusive English high class and luxurius model, is provided by a silken 563-hp twin-turbo V-12 paired with an eight-speed automatic and rear-wheel drive. 
                Acceleration is brisk, but Rolls-Royce's claimed 5.1-second zero-to-60-mph time  </p>

            <br /><br />

            <p>We would be pleased of letting our guesses try this elegant luxury Rolls-Royce!</p>

            <div class="reservaBoton">
               <p> RESERVE NOW </p>
            </div>

        </div>
        
    </div>

    <div class="car">

        <div class="foto">
            <img src="assets/coche_4.jpg" width="475" height="375"/>
        </div>

        <div class ="texto">
            <h1> Mercedes-Maybach 6 </h1>

            <br />

            <p> The Vision Mercedes-Maybach 6, represents the ultimate in contemporary luxury. 
                It is hot and cool”, states Gorden Wagener, Chief Design Officer Daimler AG.
                The output of the drive system is 550 kW (750 PS), a high-performance combined with
                the most prestigius designs.
            </p>

            <br /><br />

            <p>We would be pleased of letting our guesses try this Maybach, unique in the world!</p>

            <div class="reservaBoton">
               <p> RESERVE NOW </p>
            </div>

        </div>
        
    </div>


</asp:Content>


