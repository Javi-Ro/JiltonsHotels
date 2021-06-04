<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Restaurant.aspx.cs" Inherits="JiltonWeb.Restaurant" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

    <asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link href="css/restaurant.css?ver=<?php echo rand(556,950)?>" rel="stylesheet">
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
                       <asp:label ID="titulo" runat="server"> </asp:label>
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
                    <asp:Panel runat="server" id="RestaurantInsertOrUpdate" Cssclass="adminTextBoxes"> <asp:Label runat="server"> Insert the new menu's date   </asp:Label> <ajax:CalendarExtender ID="DateMenu" runat="server" TargetControlID="DateTB" Format="dd/MM/yyyy"/><asp:TextBox ID="DateTB"  AutoComplete="off" OnKeyPress="return false;" runat="server"> </asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="Validator" runat="server" ValidationGroup="RestaurantGroup" ErrorMessage="This field is required" ControlToValidate="DateTB" Display="Dynamic"></asp:RequiredFieldValidator>  
                            <asp:Label runat="server" ID="appetizersLabel"> 
                            Insert appetizers  </asp:Label><asp:TextBox TextMode="MultiLine" Rows="1" runat="server" ID="appetizersTB"> </asp:TextBox> 
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorAppetizers" CssClass="Validator" runat="server" ValidationGroup="RestaurantGroup" ErrorMessage="This field is required" ControlToValidate="appetizersTB" Display="Dynamic"></asp:RequiredFieldValidator>  
                            <asp:Label runat="server" ID="mainLabel"> 
                            Insert main course   </asp:Label><asp:TextBox TextMode="MultiLine" Rows="1" runat="server" ID="mainTB"> </asp:TextBox> 
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorMains" CssClass="Validator" runat="server" ValidationGroup="RestaurantGroup" ErrorMessage="This field is required" ControlToValidate="mainTB" Display="Dynamic"></asp:RequiredFieldValidator>  
                            <asp:Label runat="server" ID="dessertLabel"> 
                            Insert dessert   </asp:Label> <asp:TextBox TextMode="MultiLine" Rows="1" runat="server" ID="dessertTB"> </asp:TextBox> 
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorDesserts" CssClass="Validator" runat="server" ValidationGroup="RestaurantGroup" ErrorMessage="This field is required" ControlToValidate="dessertTB" Display="Dynamic"></asp:RequiredFieldValidator>  
                            <asp:Label runat="server" ID="priceLabel"> 
                             Insert price   </asp:Label><asp:TextBox runat="server" ID="priceTB"> </asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPrice" CssClass="Validator" runat="server" ValidationGroup="RestaurantGroup" ErrorMessage="This field is required" ControlToValidate="priceTB" Display="Dynamic"></asp:RequiredFieldValidator>  
                            <asp:RangeValidator ID="RangePrice" CssClass="ValidatorRange" ValidationGroup="RestaurantGroup" MinimumValue="0" MaximumValue="1000" Type="Integer" Text="Price must be a number" ControlToValidate="priceTB" Display="Dynamic" runat="server"></asp:RangeValidator>
                    
                                 <div class="CreateorInsert">
                                    <asp:Button  runat="server" CssClass="AdminButton" Text="Create menu" ID="Create" ValidationGroup="RestaurantGroup"  OnClick="OnCreate" />
                                </div><div class="CreateorInsert">
                                    <asp:Button  runat="server" CssClass="AdminButton" Text="Update menu" ValidationGroup="RestaurantGroup" ID="Update" OnClick="OnUpdate" Visible="false" />
                                </div>
                                
                    </asp:Panel>
                    <asp:Panel runat="server" id="DeletePanel" Cssclass="invisible"> <asp:Label runat="server"> Insert the new menu's date   </asp:Label> <ajax:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="DateTB2" Format="dd/MM/yyyy"/><asp:TextBox ID="DateTB2"  OnKeyPress="return false;" runat="server"> </asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="Validator" runat="server" ValidationGroup="RestaurantGroup2" ErrorMessage="This field is required" ControlToValidate="DateTB2" Display="Dynamic"></asp:RequiredFieldValidator>  
                             <div class="Delete">
                                <asp:Button  runat="server" CssClass="AdminButton" Text="Delete menu" ID="Delete" ValidationGroup="RestaurantGroup2" OnClick="OnDelete" Visible="true"/>
                            </div>
                    </asp:Panel>

                    <asp:Label visible="false" runat="server" ID="success" CssClass="SuccessLabel"> </asp:Label>
                    <asp:Label visible="false" runat="server" ID="Error" CssClass="ErrorLabel"> </asp:Label>       
                </div>
            </asp:Panel>
        </asp:Panel>
</asp:Content>
