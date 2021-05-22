<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Room.aspx.cs" Inherits="JiltonWeb.Room" EnableEventValidation="false" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link href="css/room.css?ver=<?php echo rand(546,950)?>" rel="stylesheet">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <asp:SqlDataSource 
            id="SqlDataSource1" 
            runat="server"
            DataSourceMode="DataReader"
            ConnectionString="<%$ ConnectionStrings:Database%>"
            SelectCommand="SELECT * FROM room">
        </asp:SqlDataSource>
           
        <div class="background" runat="server">

        <div class="webBorder">
          <div class="filterBox">
              <div class="dropdown">
                  <asp:Button runat="server" Text="Order" CssClass="dropbtn" />
                    <div class="dropdown-content">
                        <asp:Button runat="server" ID="MyProfile" CssClass="dropdown-Buttons" Text="Ratings" OnClientClick="this.disabled=true;"/>
                        <asp:Button runat="server" ID="MyBookings" CssClass="dropdown-Buttons" Text="Price (lowest first)" OnClick="showLowest"/>
                        <asp:Button runat="server" ID="LogOutButton" CssClass="dropdown-Buttons" Text="Price (highest first)"  />
                    </div>
                </div>

                <div class="dropdown">
                  <asp:Button runat="server" Text="Type" CssClass="dropbtn" />
                  <div class="dropdown-content">
                        <asp:Button runat="server" ID="Button1" CssClass="dropdown-Buttons" Text="Single" OnClientClick="this.disabled=true;"/>
                        <asp:Button runat="server" ID="Button2" CssClass="dropdown-Buttons" Text="Double" OnClientClick="this.disabled=true;"/>
                        <asp:Button runat="server" ID="Button3" CssClass="dropdown-Buttons" Text="Triple" />
                        <asp:Button runat="server" ID="Button4" CssClass="dropdown-Buttons" Text="Deluxe" OnClientClick="this.disabled=true;"/>
                        <asp:Button runat="server" ID="Button5" CssClass="dropdown-Buttons" Text="Executive" OnClientClick="this.disabled=true;"/>
                        <asp:Button runat="server" ID="Button6" CssClass="dropdown-Buttons" Text="Presidential"/>   
                  </div>
                </div>
              <div class="dropdown">
                   <asp:Button runat="server" Text="Ratings" CssClass="dropbtn" />
                  <div class="dropdown-content">
                        <asp:Button runat="server" ID="Button7" CssClass="dropdown-Buttons" Text="1" OnClientClick="this.disabled=true;"/>
                        <asp:Button runat="server" ID="Button8" CssClass="dropdown-Buttons" Text="2" OnClientClick="this.disabled=true;"/>
                        <asp:Button runat="server" ID="Button9" CssClass="dropdown-Buttons" Text="3" />
                        <asp:Button runat="server" ID="Button10" CssClass="dropdown-Buttons" Text="4" OnClientClick="this.disabled=true;"/>
                        <asp:Button runat="server" ID="Button11" CssClass="dropdown-Buttons" Text="5" OnClientClick="this.disabled=true;"/>
                  </div>
                </div>
                
              <div class="textInside">
                  <asp:Label runat="server"> 

                  • Cancellation free of charge

                  • Free room service

                  • Free Wi-Fi in every room

                    Select your budget:
                  </asp:Label>
              </div>
              
                <div class="slider">
                    <asp:TextBox ID="TB1" runat="server"> </asp:TextBox>
                    <asp:TextBox ID="Control" runat="server" visible="false"></asp:TextBox>
                           <ajax:SliderExtender TooltipText = "{0}" EnableHandleAnimation="true" RaiseChangeOnlyOnMouseUp="true" Maximum="1500" Minimum="150" ID="SliderExtender1" BoundControlID="Control" TargetControlID ="TB1" runat="server" />
                </div>

                    
              <div class="search">
               <button class="searchButton"> Search </button>
              </div>

            </div>
            </div>
            <div class="webBorder3">
            <div class="blurryBackground" runat="server">
               
                
                     <asp:GridView ID="GridView1" CssClass="grid" runat="server" showHeader="false"  DataSourceID="SqlDataSource1" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">  
                         <emptydatarowstyle CssClass="emptyRow"/>
                    
                            <emptydatatemplate>
                                <asp:Label runat="server" CssClass="textWhenEmpty" Text = "No rooms with these characteristics were found. Try to apply different filters. Sorry for the inconvenience"></asp:Label>
                                <asp:Image id="imagen" runat="server" ImageUrl="assets/jiltonLogo2.png" width="250px" style="position:absolute; top:20%; left:50%; transform:translateX(-50%);"/>
                            </emptydatatemplate> 
                         <Columns >
  
                            <asp:BoundField DataField="id" ReadOnly="true" Visible="false" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <div class="room">
                                        <div class="row">
                                            <div class="Informacion">
                                                <asp:Label ID="Label1" runat="server" CssClass="titulo" Text='<%# Eval("title") %>'></asp:Label>
                                                
                                                <br />
                                                <br />
                                                <asp:Label ID="Label2" runat="server"  CssClass="field"> Description: </asp:Label>
                                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("description") %>'> </asp:Label>
                                                <br />
                                                <br />
                                                <asp:Label ID="Label4" runat="server"  CssClass="field"> Category: </asp:Label>
                                                <asp:Label ID="Label5" runat="server" Text='<%# Eval("type") %>' >   </asp:Label>
                                                | King beds: 
                                                <asp:Label ID="Label6" runat="server" Text='<%# Eval("AdultBed") %>' >  </asp:Label>
                                                | Single beds:
                                                <asp:Label ID="Label7" runat="server" Text='<%# Eval("ChildBed") %>' > </asp:Label>
                                                <br />
                                                <br />
                                                <asp:Label ID="Label8" runat="server"  CssClass="field"> Overnight price: </asp:Label>
                                                <asp:Label ID="Label9" runat="server" Text='<%# Eval("price") %>' > </asp:Label>
                                                €
                                                
                                             <%--   <div class="ratingStar">
                                                    <asp:Image runat="server" CssClass="imagen2" ImageUrl="assets/ratings2.png"/> 
                                                </div>--%>
                                                
                                                 
                                                
                                                <asp:Panel runat="server" ID="adminViewRoom" CssClass="iconoHidden">
                                                    <asp:Image CssClass="imagen" ID="deleteImage" runat="server" ImageUrl="assets/deleteIcon.png" />
                                                    <asp:Image  CssClass="imagen" ID="UpdateImage" runat="server" ImageUrl="assets/editIcon.png" />
                                                </asp:Panel>
                                                <%--<ajax:Rating runat="server" ID="Rating1"
                                                    MaxRating="5"
                                                    CurrentRating="2"
                                                    CssClass="ratingStar"
                                                    StarCssClass="ratingItem"
                                                    WaitingStarCssClass="Saved"
                                                    FilledStarCssClass="Filled"
                                                    EmptyStarCssClass="Empty"
                                                    >
                                                </ajax:Rating>--%>
                                                

                                             </div>
                                            <div class="FotoContenedor">
                                                    
                                                    <asp:Image Cssclass="resize" ID="Image1" runat="server" ImageUrl='<%# Eval("imgURL") %>'/>
                                                   
                                           </div>
                                           </div>
                                        <div class="add">
                                                   <asp:Button  runat="server" Cssclass="addButton" onClick="addButton" Text="Add"/>
                                                  </div>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                     
<RowStyle CssClass="bottomBorder"></RowStyle>
                     
                     </asp:GridView>                 

                
                
            </div>
            </div>
            <div class="webBorder2">
            <div class="orderBox">
               <div class="selectionLabel"> 
                   <asp:Label runat="server"> Your selection </asp:Label>
               </div>
                <div class="gridContainer">
                      <asp:GridView ID="GridViewRooms" CssClass="grid2"  runat="server" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false" CellSpacing="8" ShowHeader="False" Width="100%" RowStyle-HorizontalAlign="Left">
                 <%--       <emptydatarowstyle CssClass="emptyRow2"/>
                    
                            <emptydatatemplate>
                                <asp:Label runat="server" CssClass="textWhenEmpty" Text = "Select any room you like"></asp:Label>
                            </emptydatatemplate> --%>
                        
                          <Columns>
                            <asp:BoundField DataField="title" ItemStyle-Width="150px"  ItemStyle-Font-Bold="true" />
                            <asp:BoundField ItemStyle-Width="50px" />
                            <asp:BoundField DataField="price" DataFormatString="{0:C}" ItemStyle-Width="80px" />
                            
                        </Columns>
                    </asp:GridView>
                </div>
                <div class="goContainer">
                    <div class="go">
                        <asp:Button  runat="server" Cssclass="searchButton" Text="Go"/>
                    </div>
                </div>
            </div>
           </div>
        </div>
              
    </asp:Content>


