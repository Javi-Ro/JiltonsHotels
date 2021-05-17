<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Restaurant.aspx.cs" Inherits="JiltonWeb.Restaurant" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

    <asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link href="css/restaurant.css?ver=<?php echo rand(551,950)?>" rel="stylesheet">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">

        <asp:Panel runat="server" ID="backgroundR" >

            <div class="Menu">
                  <asp:Button runat="server" class="MenuButton" onclick="OnPrevious" id="PreviousButton" Text="PREVIOUS MENU"/>
            </div>
            <div class="Menu">
                  <asp:Button runat="server"  class="MenuButton" onclick="OnToday" id="TodayButton" Text="TODAY'S MENU" />
            </div>
            <div class="Menu">
                  <asp:Button runat="server" class="MenuButton" onclick="OnNext" id="NextButton" Text="NEXT MENU" />
            </div>
            
            <div class="blurryBackground">

                <div class="plainBackground">
                   <div class ="RestaurantTitle" runat="server">
                       <asp:label ID="titulo" runat="server">                    
                       </asp:label>
                   </div>
                    <br />
                    <asp:Image id="imagen" runat="server" ImageUrl="assets/jiltonLogo2.png" width="290px" visible="false" style="position:absolute; left:50%; transform:translateX(-50%);"/>
                      
                                     
                    <div class ="subTitle" runat="server">
                       <asp:label runat="server" ID="meal1"> APPETIZERS </asp:label>
                   </div>

                    <div class ="Meal" runat="server">
                       <asp:label ID="APPETIZERS" runat="server"> 

                       </asp:label>
                   </div>
                
                    <div class ="subTitle" runat="server">
                       <asp:label runat="server" ID="meal2"> MAIN COURSE </asp:label>
                   </div>
                    <div class ="Meal" runat="server">
                       <asp:label ID="MAINS" runat="server">
                       </asp:label>
                   </div>

                    <div class ="subTitle" runat="server">
                       <asp:label runat="server" ID="meal3"> DESSERTS </asp:label>
                   </div>
                    <div class ="Meal" runat="server">
                       <asp:label ID="DESSERTS" runat="server">
                       </asp:label>

                        <asp:Label runat="server" ID="PRICE"> 250€</asp:Label>
                    </div>
                    <div class ="subTitle" runat="server">
                       <asp:label runat="server" ID="EndMessage"> Feel free to ask for our superb wine selection </asp:label>

                   </div>
               </div>
    
            </div>
     
            
            <asp:Panel CssClass="noAdmin" ID="AdminBlurryBackground" runat="server">
               <div class="MenuAdmin">
                    <asp:Button runat="server" class="MenuButton" ID="CreateButton" Text="CREATE MENU" OnClick="InsertPage"/>
               </div>
               <div class="MenuAdmin">
                   <asp:Button runat="server" class="MenuButton" ID="UpdateButton" Text="UPDATE MENU" OnClick="UpdatePage"/>
               </div>
               <div class="MenuAdmin">
                   <asp:Button runat="server" class="MenuButton" ID="DeleteMenu" Text="DELETE MENU" OnClick="DeletePage"/>
               </div>
                <div class="adminBox">
                    <div class="adminTextBoxes"> <asp:Label runat="server"> Insert the new menu's date   </asp:Label> <ajax:CalendarExtender ID="DateMenu" runat="server" TargetControlID="DateTB" Format="dd/MM/yyyy"/><asp:TextBox ID="DateTB" runat="server"> </asp:TextBox> <asp:Label runat="server" CssClass="ErrorMessages" ID="ErrorDate" Visible="false"> This field must be known </asp:Label>
                
                        <asp:Label runat="server" ID="appetizersLabel"> 
                        Insert appetizers  </asp:Label><asp:TextBox TextMode="MultiLine" Rows="1" runat="server" ID="appetizersTB"> </asp:TextBox> <asp:Label runat="server" CssClass="ErrorMessages" ID="ErrorApp" Visible="false"> This field must be known </asp:Label>
                
                    <asp:Label runat="server" ID="mainLabel"> 
                        Insert main course   </asp:Label><asp:TextBox TextMode="MultiLine" Rows="1" runat="server" ID="mainTB"> </asp:TextBox> <asp:Label runat="server" CssClass="ErrorMessages" ID="ErrorMain" Visible="false"> This field must be known </asp:Label>
                
                    <asp:Label runat="server" ID="dessertLabel"> 
                        Insert dessert   </asp:Label><asp:TextBox TextMode="MultiLine" Rows="1" runat="server" ID="dessertTB"> </asp:TextBox><asp:Label runat="server" CssClass="ErrorMessages" ID="ErrorDessert" Visible="false"> This field must be known </asp:Label>

                    <asp:Label runat="server" ID="priceLabel"> 
                        Insert price   </asp:Label><asp:TextBox runat="server" ID="priceTB"> </asp:TextBox> <asp:Label runat="server" CssClass="ErrorMessages" ID="ErrorPrice" Visible="false"> This field must be known </asp:Label>
                    </div>

                    <asp:Label visible="false" runat="server" ID="success" CssClass="SuccessLabel"> </asp:Label>
                
                    <asp:Label visible="false" runat="server" ID="Error" CssClass="ErrorLabel"> </asp:Label>
                                
                    <div class="Create">
                        <asp:Button  runat="server" CssClass="AdminButton" Text="Create menu" ID="Create" OnClick="OnCreate" />
                    </div>
                    <div class="Create">
                        <asp:Button  runat="server" CssClass="AdminButton" Text="Update menu" ID="Update" OnClick="OnUpdate" Visible="false" />
                    </div>
                    <div class="Create">
                        <asp:Button  runat="server" CssClass="AdminButton" Text="Delete menu" ID="Delete" OnClick="OnDelete" Visible="false"/>
                    </div>
                </div>
            </asp:Panel>


           </asp:Panel>
           
    </asp:Content>
