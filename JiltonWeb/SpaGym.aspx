<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="SpaGym.aspx.cs" Inherits="JiltonWeb.SpaGym" %>

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
 
            <asp:GridView ID="GridView1" runat="server" Font-Size="18px" ForeColor="#F3E7E7" GridLines="None" AutoGenerateColumns="false" CellSpacing="14" ShowHeader="false">
                <Columns>
                    <asp:ImageField DataImageUrlField="imgURL" ControlStyle-BorderStyle="Inset" ControlStyle-Height="600px" ControlStyle-Width="600px"></asp:ImageField>
                    <asp:BoundField DataField="description" />
                    <asp:ButtonField Text="RESERVE" ControlStyle-BorderColor="#400040" />
                </Columns>
            </asp:GridView> 

        </div>

        <div class="gym">
            <div class="titulo2">
                <h1 ><b> GYM </b></h1>
            </div>
            <br />

            <asp:GridView ID="GridView2" runat="server"  Font-Size="18px" ForeColor="#F3E7E7" GridLines="None" AutoGenerateColumns="false" CellSpacing="12" ShowHeader="false">
                <Columns>
                    <asp:ImageField DataImageUrlField="imgURL" ControlStyle-BorderStyle="Inset" ControlStyle-Height="600px" ControlStyle-Width="600px"></asp:ImageField>
                    <asp:BoundField DataField="description" />
                    <asp:ButtonField Text="RESERVE" />
                </Columns>
            </asp:GridView>

        </div>

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
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="texto44"></asp:TextBox>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="texto44"></asp:TextBox>
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="texto44"></asp:TextBox>
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="texto44"></asp:TextBox>
                    <asp:TextBox ID="TextBox5" runat="server" CssClass="texto44"></asp:TextBox>
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="texto44"></asp:TextBox>
                    <asp:TextBox ID="TextBox7" runat="server" CssClass="texto44"></asp:TextBox>
                </div>
            </div>
                
            <div class="botones">
                <asp:Button CssClass="create" ID="create" runat="server" Text="Create Service" />
                <asp:Button CssClass="delete" ID="delete" runat="server" Text="Delete Service" />
                <asp:Button CssClass="update" ID="update" runat="server" Text="Update Service" />
            </div>

            <div class="tutle">
                <p> <b>Here the administrator will update the service`s page</b></p>
            </div>
            <br />
        </div>


    </div>
            
</asp:Content>
