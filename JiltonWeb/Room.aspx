<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Room.aspx.cs" Inherits="JiltonWeb.Room" EnableEventValidation="false" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link href="css/room.css?ver=<?php echo rand(565,950)?>" rel="stylesheet">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
           
        <div class="background" runat="server">

        <div class="webBorder">
          <div class="filterBox">
              <asp:DropDownList id="orderList"
                    AutoPostBack="False"
                    runat="server" CssClass="item">
                  <asp:ListItem selected="true" disabled="true" Value="unselected"> Order by </asp:ListItem>
                  <asp:ListItem Value="Lowest"> Lowest price </asp:ListItem>
                  <asp:ListItem Value="Highest"> Highest price </asp:ListItem>

               </asp:DropDownList>

               <asp:DropDownList id="typeList"
                    AutoPostBack="False"
                    runat="server" CssClass="item">
                  <asp:ListItem selected="true"  disabled="true" Value="unselected"> Type </asp:ListItem>
                  <asp:ListItem Value="single"> Single </asp:ListItem>
                  <asp:ListItem Value="double"> Double </asp:ListItem>
                  <asp:ListItem Value="triple"> Triple </asp:ListItem>
                  <asp:ListItem Value="deluxe"> Deluxe </asp:ListItem>
                  <asp:ListItem Value="executive"> Executive </asp:ListItem>
                  <asp:ListItem Value="presidential"> Presidential </asp:ListItem>

               </asp:DropDownList>

                
              <div class="textInside">
                  <asp:Label runat="server"> 


                  • Cancellation free of charge

                  • Free room service

                  • Free Wi-Fi in every room

                  Select a budget: <asp:TextBox ID="Control" CssClass="budget" runat="server" Text="€" ></asp:TextBox><asp:Label runat="server" Text="€"> </asp:Label>
                  </asp:Label>
              </div>
                <div class="slider">
                    
                    <asp:TextBox ID="SliderValue" runat="server"> </asp:TextBox>
         
                           <ajax:SliderExtender TooltipText = "Select your budget: " RailCssClass="ajax__slider_h_rail" HandleCssClass="ajax__slider_h_handle" EnableHandleAnimation="true"  RaiseChangeOnlyOnMouseUp="true" Maximum="2100" Minimum="350" ID="SliderExtender1" BoundControlID="Control" TargetControlID ="SliderValue" runat="server" />
           
                </div>

                    
              <div class="search">
               <asp:Button runat="server" onClick="onSearch" CssClass="searchButton" Text="Search"/>
              </div>

            </div>
            </div>
            <div class="webBorder3">
            <div class="blurryBackground" runat="server">
               
                
                     <asp:GridView ID="GridView1" allowpaging="true"  CssClass="grid" runat="server" showHeader="false" AutoGenerateColumns="False" OnPageIndexChanging="gridview_PageIndexChanging">  
                         <emptydatarowstyle CssClass="emptyRow"/>

                             <pagersettings mode="Numeric"
                              position="Bottom"           
                              pagebuttoncount="10"/>
                      
                            <pagerstyle horizontalalign="Center" height="30px" cssClass="paginacion"/>
                    
                            <emptydatatemplate>
                                <asp:Label runat="server" CssClass="textWhenEmpty" Text = "No rooms with these characteristics were found. Try to apply different filters. Sorry for the inconvenience"></asp:Label>
                                <asp:Image id="imagen" runat="server" ImageUrl="assets/jiltonLogo2.png" width="250px" style="position:absolute; top:80px; left:50%; transform:translateX(-50%);"/>
                            </emptydatatemplate> 
                         <Columns >
  
                            <asp:BoundField DataField="id" ReadOnly="true"/>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <div class="room">
                                        <div class="row">
                                            <div class="Informacion">
                                                <asp:Label ID="idLabel" Visible="true" runat="server" Text='<%# Eval("id") %>'></asp:Label>
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

                <asp:Panel runat="server" ID="adminViewRoom" CssClass="invisible">
                        <div class="Room2">
                            <asp:Button runat="server" class="RoomButton" ID="CreateButton" Text="CREATE ROOM" OnClick="InsertInterface"/>
                       </div>
                       <div class="Room2">
                           <asp:button runat="server" class="RoomButton" ID="UpdateButton" text="UPDATE ROOM" OnClick="UpdateInterface" />
                       </div>
                       <div class="Room2">
                           <asp:button runat="server" class="RoomButton" ID="DeleteMenu" text="DELETE ROOM" OnClick="DeleteInterface"/>
                       </div>
                    <div class="adminBox">
                        <asp:Panel runat="server" ID="InsertOrUpdate" CssClass="visible">
                            <asp:Panel runat="server" ID="onlyUpdateID" CssClass="invisible">
                                <asp:label runat="server" width="35%"> Room ID </asp:label><asp:textbox Visible="false" id ="roomIDUpdate" height="30px" runat ="server" />
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidatorIDupdate" CssClass="Validator" runat="server"  ValidationGroup="RoomGroup" ErrorMessage="This field is required" ControlToValidate="roomIDUpdate" Display="Dynamic"></asp:RequiredFieldValidator>  <asp:RangeValidator ID="RangeValidatorIDupdate" CssClass="ValidatorRange" ValidationGroup="RoomGroup" MinimumValue="0" MaximumValue="1000000" Type="Integer" Text="ID must be a number" ControlToValidate="roomIDUpdate" Display="Dynamic" runat="server"></asp:RangeValidator>                          
                            </asp:Panel>
                             <asp:label runat="server" width="35%"> Name </asp:label><asp:textbox id ="nameTB" height="30px" runat ="server" />
                             <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" CssClass="Validator" runat="server" ValidationGroup="RoomGroup" ErrorMessage="This field is required" ControlToValidate="nameTB" Display="Dynamic"></asp:RequiredFieldValidator>  
                            
                            <asp:label runat="server" width="35%"> Description </asp:label><asp:textbox id ="descriptionTB" height="30px" runat ="server" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorDescription" CssClass="Validator" runat="server" ValidationGroup="RoomGroup" ErrorMessage="This field is required" ControlToValidate="descriptionTB" Display="Dynamic"></asp:RequiredFieldValidator>  
                            
                            <asp:label runat="server" width="35%"> Price </asp:label><asp:textbox id ="priceTB" height="30px" runat ="server" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPrice" CssClass="Validator" runat="server" ValidationGroup="RoomGroup" ErrorMessage="This field is required" ControlToValidate="priceTB" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidatorPrice" CssClass="ValidatorRange" ValidationGroup="RoomGroup" MinimumValue="350" MaximumValue="2100" Type="Integer" Text="Integer between 350 and 2100" ControlToValidate="priceTB" Display="Dynamic" runat="server"></asp:RangeValidator>                             
                            <asp:label runat="server" width="35%"> Type </asp:label><asp:DropDownList id="TypeTB" CssClass="ddlstyle" 
                                    runat="server">

                                  <asp:ListItem Selected="True" Value="single"> Single </asp:ListItem>
                                  <asp:ListItem Value="double"> Double </asp:ListItem>
                                  <asp:ListItem Value="triple"> Triple </asp:ListItem>
                                  <asp:ListItem Value="deluxe"> Deluxe </asp:ListItem>
                                  <asp:ListItem Value="executive"> Executive </asp:ListItem>
                                  <asp:ListItem Value="presidential"> Presidential </asp:ListItem>
                        
                            </asp:DropDownList>
         

                             <asp:label runat="server" width="35%"> Number of king beds </asp:label><asp:textbox id ="kingBedTB" height="30px" runat ="server" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorKingBed" CssClass="Validator" runat="server" ValidationGroup="RoomGroup" ErrorMessage="This field is required" ControlToValidate="kingBedTB" Display="Dynamic"></asp:RequiredFieldValidator>  
                            <asp:RangeValidator ID="RangeValidatorKingBed" CssClass="ValidatorRange" ValidationGroup="RoomGroup" MinimumValue="0" MaximumValue="3" Type="Integer" Text="Integer between 0 and 3" ControlToValidate="kingBedTB" Display="Dynamic" runat="server"></asp:RangeValidator>                            
                            <asp:label runat="server" width="35%"> Number of single beds </asp:label><asp:textbox id ="childBedTB" height="30px" runat ="server" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorSingleBed" CssClass="Validator" runat="server" ValidationGroup="RoomGroup" ErrorMessage="This field is required" ControlToValidate="childBedTB" Display="Dynamic"></asp:RequiredFieldValidator>  
                            <asp:RangeValidator ID="RangeValidatorSingleBed" CssClass="ValidatorRange" ValidationGroup="RoomGroup" MinimumValue="0" MaximumValue="4" Type="Integer" Text="Integer between 0 and 4" ControlToValidate="childBedTB" Display="Dynamic" runat="server"></asp:RangeValidator>                           
                             
                            <asp:label runat="server" width="35%"> Image URL </asp:label><asp:textbox id ="imageTB" Text="assets/room1.jpg" height="30px" runat ="server" />
                            <div class="Create">
                                <asp:Button  runat="server" CssClass="AdminButton" Text="Create room" ID="Insert" Visible="true" ValidationGroup="RoomGroup" OnClick="onInsert" />
                            </div>
                            <div class="Create">
                                <asp:Button  runat="server" CssClass="AdminButton" Text="Update room" Visible="false" ID="Update" ValidationGroup="RoomGroup" OnClick="onUpdate"/>
                            </div>
                            <asp:Label runat="server" id="success" CssClass="SuccessLabel" Visible="false"> </asp:Label>
                            <asp:Label runat="server" id="error" CssClass="ErrorLabel" Visible="false"> </asp:Label>
                          </asp:Panel>
                          <asp:Panel runat="server" ID="deletePanel" CssClass="invisible">
                              <asp:label runat="server" width="35%"> Room ID </asp:label><asp:textbox id ="roomID" height="30px" runat ="server" />
                             <asp:RequiredFieldValidator ID="RequiredFieldValidatorDeleteID" CssClass="Validator" runat="server" ValidationGroup="RoomIDinDelete" ErrorMessage="This field is required" ControlToValidate="roomID" Display="Dynamic"></asp:RequiredFieldValidator>  
                              <asp:RangeValidator ID="RangeValidatorIDdelete" CssClass="ValidatorRange" ValidationGroup="RoomIDinDelete" MinimumValue="0" MaximumValue="1000000" Type="Integer" Text="ID must be a number" ControlToValidate="roomID" Display="Dynamic" runat="server"></asp:RangeValidator>                             
                            <div class="Create">
                                <asp:Button  runat="server" CssClass="AdminButton" Text="Delete room" ID="Delete" ValidationGroup="RoomIDinDelete" OnClick="onDelete"/>
                            </div>
                          </asp:Panel>
                   
                            
                    </div>
                   
                </asp:Panel>
                
            </div>
            </div>
            <div class="webBorder2">
            <div class="orderBox">
               <div class="selectionLabel"> 
                   <asp:Label runat="server"> Your selection </asp:Label>
               </div>
                <div class="gridContainer">
                      <asp:GridView ID="GridViewRooms" CssClass="grid2"  runat="server" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false" CellSpacing="8" ShowHeader="False" Width="100%" RowStyle-HorizontalAlign="Left">
                            <emptydatatemplate>
                                <asp:Label runat="server" CssClass="textWhenEmpty" Text = "At least one room must be selected "></asp:Label>
                            </emptydatatemplate> 
                        
                          <Columns>
                            <asp:BoundField DataField="id" ItemStyle-Font-Bold="true" />
                            <asp:BoundField DataField="title" ItemStyle-Width="150px"  ItemStyle-Font-Bold="true" />
                            <asp:BoundField ItemStyle-Width="50px" />
                            <asp:BoundField DataField="price" DataFormatString="{0:C}" ItemStyle-Width="80px" />
                            
                        </Columns>
                    </asp:GridView>
                </div>
                <div class="goContainer">
                    <div class="go">
                        <asp:Button id="goButton" visible="false" runat="server" Cssclass="searchButton" Text="Go" OnClick="GoButton_Click"/>
                    </div>
                </div>
                 <asp:Label ID="errorRepeated" runat="server" CssClass="repeated" Visible="false" Text="You cannot select the same room twice"></asp:Label>
            </div>
               
           </div>
        </div>
              
    </asp:Content>


