<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Room.aspx.cs" Inherits="JiltonWeb.Room" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>
    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link href="css/room.css?ver=<?php echo rand(543,950)?>" rel="stylesheet">
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
                  <button class="dropbtn">Order </button>
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
                                                
                                                <div class="ratingStar">
                                                    <asp:Image runat="server" CssClass="imagen2" ImageUrl="assets/ratings2.png"/> 
                                                </div>

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
                    (Selected rooms go here)
                <div class="Go">
                    <asp:Button  runat="server" CssClass="searchButton" Text="Go" OnClick="GoButton_Click"></asp:Button>
                </div>
            </div>
           </div>
        </div>
              
    </asp:Content>


