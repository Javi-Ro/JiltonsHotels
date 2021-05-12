<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Restaurant.aspx.cs" Inherits="JiltonWeb.Restaurant" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

    <asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link href="css/restaurant.css?ver=<?php echo rand(533,950)?>" rel="stylesheet">
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
                       <asp:label ID="APPETIZERS" runat="server"> 
                           Slow-cooked Duck Egg, Iberico Ham, Spring White Truffle

                            Confit Foie Gras, Smoked Eel, Granny Smith Apple

                       </asp:label>
                   </div>
                
                    <div class ="subTitle" runat="server">
                       <asp:label runat="server"> MAIN COURSE </asp:label>
                   </div>
                    <div class ="Meal" runat="server">
                       <asp:label ID="MAINS" runat="server">
                        Saffron Risotto, Carabineros Prawns, Gold leaf

                        Wagyu Beef with Fermented Celeriac and Silver leaf (Served on Dry Ice)

                        Braised Beef Cheeks with Potato Mousseline
                       </asp:label>
                   </div>

                    <div class ="subTitle" runat="server">
                       <asp:label runat="server"> DESSERTS </asp:label>
                   </div>
                    <div class ="Meal" runat="server">
                       <asp:label ID="DESSERTS" runat="server">
                           Golden Opulence Sundae.

                            Dark chocolate cylinder and smoked hazelnut praline
                       </asp:label>
                    </div>
                    <div class ="subTitle" runat="server">
                       <asp:label runat="server"> Feel free to ask for our superb wine selection

                       </asp:label>
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

            <div class="adminBox">
                <div class="adminTextBoxes"> <asp:Label runat="server"> Insert the new menu's date   </asp:Label> <ajax:CalendarExtender ID="DateMenu" runat="server" TargetControlID="Date" Format="dd/MM/yyyy"> </ajax:CalendarExtender> <asp:TextBox ID="Date" runat="server"> </asp:TextBox>
                
                    <asp:Label runat="server"> 
                    Insert appetizers  </asp:Label><asp:TextBox runat="server"> </asp:TextBox>
                
                <asp:Label runat="server"> 
                    Insert main course   </asp:Label><asp:TextBox runat="server"> </asp:TextBox>
                
                <asp:Label runat="server"> 
                    Insert dessert   </asp:Label><asp:TextBox runat="server"> </asp:TextBox>
                </div>
                <div class="Create">
                    <asp:Button  runat="server" CssClass="AdminButton" Text="Create menu" ></asp:Button>
                </div>

            </div>


           </div>
           
    </asp:Content>
