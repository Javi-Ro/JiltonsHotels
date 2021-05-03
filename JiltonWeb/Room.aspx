﻿<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Room.aspx.cs" Inherits="JiltonWeb.Room" %>

    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link href="css/room.css" rel="stylesheet">
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
          
              <asp:Label runat="server"> 
                  Your budget (per night)
                  Aqui va un slider
              </asp:Label>

            </div>
            </div>

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
              
    </asp:Content>


