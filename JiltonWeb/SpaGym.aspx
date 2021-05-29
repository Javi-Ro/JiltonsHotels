﻿<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="SpaGym.aspx.cs" Inherits="JiltonWeb.SpaGym" %>

<asp:Content ID="cssLink" ContentPlaceHolderID="cssLink"  runat="server">
    <link rel="stylesheet" href="../css/spagym.css?ver=<?php echo rand(101,999)?>" />
    <link href="https://fonts.googleapis.com/css2?family=IM+Fell+Double+Pica:ital@1&display=swap" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 

    <div class="total">

        <div class="spa">
            
            <div class="titulo1">
                <h1 ><b> ASIAN SPA </b></h1>
            </div>  
            <br />
 
            <asp:GridView ID="GridView1" Font-Bold="true" Font-Underline="false" runat="server" Font-Size="18px" ForeColor="#F3E7E7" GridLines="None" AutoGenerateColumns="false" CellSpacing="14" ShowHeader="false">
                <Columns>
                    <asp:ImageField DataImageUrlField="imgURL" ControlStyle-BorderStyle="Inset" ControlStyle-Height="600px" ControlStyle-Width="600px"></asp:ImageField>
                    <asp:BoundField DataField="description" />
                    <asp:ButtonField Text="RESERVE" ControlStyle-CssClass="botonya" ControlStyle-BorderColor="#400040" ButtonType="Button" />
                </Columns>
            </asp:GridView> 

        </div>

        <div class="gym">
            <div class="titulo2">
                <h1 ><b> GYM </b></h1>
            </div>
            <br />

            <asp:GridView ID="GridView2" runat="server"  Font-Size="18px" Font-Bold="true" ForeColor="#000000" GridLines="None" AutoGenerateColumns="false" CellSpacing="12" ShowHeader="false">
                <Columns>
                    <asp:ImageField DataImageUrlField="imgURL" ControlStyle-BorderStyle="Inset" ControlStyle-Height="600px" ControlStyle-Width="600px"></asp:ImageField>
                    <asp:BoundField DataField="description" />
                    <asp:ButtonField Text="RESERVE" ControlStyle-CssClass="botonya" ControlStyle-BorderColor="#400040" ButtonType="Button"/>
                </Columns>
            </asp:GridView>

        </div>


        <asp:Panel runat="server" ID="adminpage">

            <div class ="super">

                <div class="title">
                    <h1 >ADMINISTRATOR`S PAGE</h1>
                </div>
                <br />

       
                    <div class="entrada">
                        <div class="textoss">
                            <asp:Label runat="server" cssClass="letra"> ID: </asp:Label>
                            <asp:Label runat="server" cssClass="letra"> Description: </asp:Label>
                            <asp:Label runat="server" cssClass="letra"> Price: </asp:Label>
                            <asp:Label runat="server" cssClass="letra"> Name: </asp:Label>
                            <asp:Label runat="server" cssClass="letra"> Max. People: </asp:Label>
                            <asp:Label runat="server" cssClass="letra"> Image URL: </asp:Label>
                            <asp:Label runat="server" cssClass="letra"> Type of service: </asp:Label>
                        </div>
                        <div class="box">
                            <asp:TextBox ID="id" runat="server" CssClass="texto44"></asp:TextBox>
                            <asp:TextBox ID="descr" runat="server" CssClass="texto44"></asp:TextBox>
                            <asp:TextBox ID="price" runat="server" CssClass="texto44"></asp:TextBox>
                            <asp:TextBox ID="name" runat="server" CssClass="texto44"></asp:TextBox>
                            <asp:TextBox ID="maxp" runat="server" CssClass="texto44"></asp:TextBox>
                            <asp:TextBox ID="image" runat="server" CssClass="texto44"></asp:TextBox>
                            <asp:TextBox ID="type" runat="server" CssClass="texto44"></asp:TextBox>
                        </div>
                    </div>
                
                    <div class="botones">
                        <asp:Button CssClass="create" OnClick="Crear" ID="create" runat="server" Text="Create Service" />
                        <asp:Button CssClass="delete" OnClick="Borrar" ID="delete" runat="server" Text="Delete Service" />
                        <asp:Button CssClass="update" OnClick="Update" ID="update" runat="server" Text="Update Service" />
                    </div>

                    <div class="textoinsertar">
                        <asp:Label ID="output" runat="server"></asp:Label>
                    </div>

                    <div class="tutle">
                        <p> <b>Here the administrator will update the service`s page</b></p>
                    </div>
                    <br />
                </div>

            </asp:Panel>     
                
        

       </div>

        
            
</asp:Content>
