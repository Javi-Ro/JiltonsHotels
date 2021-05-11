<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Restaurant.aspx.cs" Inherits="JiltonWeb.Restaurant" %>

    <asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link href="css/restaurant.css?ver=<?php echo rand(531,950)?>" rel="stylesheet">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">

        <div class="backgroundR" >

            <div class="Menu">
                  <button class="MenuButton">PREVIOUS MENU</button>
            </div>
            <div class="Menu">
                  <button class="MenuButton">TODAY'S MENU</button>
            </div>
            <div class="Menu">
                  <button class="MenuButton">NEXT MENU</button>
            </div>
            <div class="blurryBackground">

                <div class="plainBackground">
                   <div class ="RestaurantTitle" runat="server">
                       <asp:label ID="titulo" runat="server"> 
                       </asp:label>
                   </div>
                    <br />
                    <div class ="subTitle" runat="server">
                       <asp:label runat="server"> APPETIZERS </asp:label>
                   </div>
                    <div class ="Meal" runat="server">
                       <asp:label ID="APPETIZERS" runat="server"> </asp:label>
                   </div>
           
                    <div class ="subTitle" runat="server">
                       <asp:label runat="server"> MAINS </asp:label>
                   </div>
                    <div class ="Meal" runat="server">
                       <asp:label ID="MAINS" runat="server"></asp:label>
                   </div>

                    <div class ="subTitle" runat="server">
                       <asp:label runat="server"> DESSERTS </asp:label>
                   </div>
                    <div class ="Meal" runat="server">
                       <asp:label ID="DESSERTS" runat="server"></asp:label>
                    </div>
               </div>
           </div>
        </div>
           
    </asp:Content>
