<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Restaurant.aspx.cs" Inherits="JiltonWeb.Restaurant" %>

    <asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link href="css/restaurant.css?ver=<?php echo rand(532,950)?>" rel="stylesheet">
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
                   <asp:label runat="server"> fjklfjñldfs
                       fdkslajfkdñljdfksfdkslajfkdñljdfks
                       kdjksajfkdlsñjffsd
                       dffgggfggfdfgfdkslajfkdñljdfks
                       kdjksajfkdlsñjffsd
                       dffgggfggfdfgfdkslajfkdñljdfks
                       kdjksajfkdlsñjffsd
                       dffgggfggfdfgvfdkslajfkdñljdfks
                       kdjksajfkdlsñjffsd
                       dffgggfggfdfgfdkslajfkdñljdfks
                       kdjksajfkdlsñjffsd
                       dffgggfggfdfgfdkslajfkdñljdfks
                       kdjksajfkdlsñjffsd
                       dffgggfggfdfgfdkslajfkdñljdfks
                       kdjksajfkdlsñjffsd
                       dffgggfggfdfg
                       kdjksajfkdlsñjffsd
                       dffgggfggfdfg
                       gf
                       dgffg

                   </asp:label> 
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
                    <div class ="Meal" runat="server">
                       <asp:label ID="Label1" runat="server"></asp:label>
                    </div>
               </div>
    
            </div>
               <div class="MenuAdmin">
                    <button class="MenuButton">CREATE MENU</button>
               </div>
               <div class="MenuAdmin">
                   <button class="MenuButton">UPDATE MENU</button>
               </div>
               <div class="MenuAdmin">
                        <button class="MenuButton">DELETE MENU</button>
               </div>
           </div>
           
    </asp:Content>
