<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Restaurant.aspx.cs" Inherits="JiltonWeb.Restaurant" %>

    <asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link href="css/restaurant.css?ver=<?php echo rand(524,950)?>" rel="stylesheet">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">

        <div class="backgroundR" >
                
            <div class="blurryBackground">

                <div class="plainBackground">
                   <div class ="RestaurantTitle" runat="server">
                       <asp:label runat="server"> TODAY'S MENU 
                       </asp:label>
                   </div>
                    <br />
                    <div class ="subTitle" runat="server">
                       <asp:label runat="server"> APPETIZERS </asp:label>
                   </div>
                    <div class ="Meal" runat="server">
                       <asp:label runat="server"> Native Oysters & Almus White Caviar

                            Slow-cooked Duck Egg, Iberico Ham, Spring White Truffle

                           Confit Foie Gras, Smoked Eel, Granny Smith Apple
                       </asp:label>
                   </div>
           
                    <div class ="subTitle" runat="server">
                       <asp:label runat="server"> MAINS </asp:label>
                   </div>
                    <div class ="Meal" runat="server">
                       <asp:label runat="server"> Saffron Risotto, Carabineros Prawns, Gold leaf 

                            Wagyu Beef with Fermented Celeriac and Silver leaf (Served on Dry Ice)

                            Braised Beef Cheeks with Potato Mousseline

                       </asp:label>
                   </div>

                    <div class ="subTitle" runat="server">
                       <asp:label runat="server"> DESSERTS </asp:label>
                   </div>
                    <div class ="Meal" runat="server">
                       <asp:label runat="server"> Golden Opulence Sundae.
                   
                             Dark chocolate cylinder and smoked hazelnut praline 

                       </asp:label>
                    </div>
               </div>
           </div>
        </div>
           
    </asp:Content>
