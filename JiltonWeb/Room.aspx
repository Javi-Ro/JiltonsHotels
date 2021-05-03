<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Room.aspx.cs" Inherits="JiltonWeb.Room" %>

    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link href="css/room.css?ver=<?php echo rand(524,950)?>" rel="stylesheet">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
       
        <div class="background" runat="server">
        <div class="webBorder">
          <div class="filterBox">
              <div class="dropdown">
                  <button class="dropbtn">Order by</button>
                  <div class="dropdown-content">
                    <a href="#">Ratings</a>
                    <a href="#">Price (lowest first) </a>
                    <a href="#">Price (highest first)</a>
                  </div>
                </div>

                <div class="dropdown">
                  <button class="dropbtn">Type</button>
                  <div class="dropdown-content">
                    <a href="#">Single</a>
                    <a href="#">Double </a>
                    <a href="#">Triple</a>
                     <a href="#">Deluxe</a>
                    <a href="#">Executive </a>
                    <a href="#">Presidential</a>
   
                  </div>
                </div>
              <div class="dropdown">
                  <button class="dropbtn">Ratings</button>
                  <div class="dropdown-content">
                    <a href="#">1</a>
                    <a href="#">2 </a>
                    <a href="#">3</a>
                     <a href="#">4</a>
                    <a href="#">5 </a>
                  </div>
                </div>
                
              <div class="search">
               <button class="searchButton"> Search </button>
              </div>

            </div>
            </div>
            <div class="webBorder3">
            <div class="blurryBackground" runat="server">
               
                <div class="room" runat="server">
                     <asp:Label runat="server"> Esto es una habitacion </asp:Label>
                </div>
                <div class="room" runat="server">
                     <asp:Label runat="server">  Esto es una habitacion </asp:Label>
                </div>
                <div class="room" runat="server">
                     <asp:Label runat="server">  Esto es una habitacion </asp:Label>
                </div>
            </div>
            </div>
            <div class="webBorder2">
            <div class="orderBox">
               <div class="selectionLabel"> 
                   <asp:Label runat="server"> Your selection </asp:Label>
               </div>
                    (Selected rooms go here)
                <div class="Go">
                    <asp:Button  runat="server" CssClass="searchButton" Text="Go" PostBackUrl="~/Booking.aspx"></asp:Button>
                </div>
            </div>
           </div>
        </div>
              
    </asp:Content>


