<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Packages.aspx.cs" Inherits="JiltonWeb.Packages" %>

<asp:Content ID="cssLink" ContentPlaceHolderID="cssLink" runat="server">
    <link rel="stylesheet" href="../css/packages.css?ver=<?php echo rand(159,999)?>" />
    <link href="https://fonts.googleapis.com/css2?family=IM+Fell+Double+Pica:ital@1&display=swap" rel="stylesheet">
    <style type="text/css">
      
    </style>

     <meta http-equiv="Expires" content="0">
    <meta http-equiv="Last-Modified" content="0">
    <meta http-equiv="Cache-Control" content="no-cache, mustrevalidate">
    <meta http-equiv="Pragma" content="no-cache">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     
    <div class="pack" >

        <asp:GridView CssClass="grid1" ID="GridView1" Font-Underline="false" runat="server" ForeColor="Black" Width="100%" GridLines="Horizontal" AutoGenerateColumns="false"  ShowHeader="false">
                <Columns>
                    <asp:ImageField DataImageUrlField="imgURL" ItemStyle-CssClass="image" ControlStyle-Height="500px" ControlStyle-Width="800px"></asp:ImageField>
                    <asp:BoundField DataField="name" ItemStyle-CssClass="name" ItemStyle-Width="150px"/>
                    <asp:BoundField DataField="description" ItemStyle-CssClass="desc" ItemStyle-Width="650px"/>
                    <asp:BoundField DataField="price" ItemStyle-CssClass="price"  DataFormatString="{0:C}" ItemStyle-Width="150px"/>
                    <asp:ButtonField Text="RESERVE" ControlStyle-CssClass="boton"  ButtonType="Button" />
                </Columns>
           </asp:GridView> 
    </div>

       <!-- <div class="image">

            <img src="assets/spa.jpg" style="width: 100%; height: 100%; object-fit: cover;"/>
        </div>

        <a href="#" style="color: black;">
        <div class="overlay">
        <div class="text">
            <h1> Pleasure Pack</h1>

            <br />

            <p> This package includes all you need to disconnect from the routine:<br />
                Daily massage (to choose)<br />
                Daily spa session<br />
            </p>

            <br />

            <p>Perfect experience for busy people</p>
        </div>
        </div>
        </a>-->
        
     

    <div class="admin">
            <div class="entradas">
                <div class = "labels">
                     <asp:Label runat="server" CssClass="letrasadmin" > Id: </asp:Label>
                     <asp:Label runat="server" CssClass="letrasadmin"> Name: </asp:Label>
                     <asp:Label runat="server" CssClass="letrasadmin"> Description: </asp:Label>
                     <asp:Label runat="server" CssClass="letrasadmin"> Price:</asp:Label>

                </div>

                <div class = "data">
                    <asp:TextBox ID ="IdData" CssClass="textboxadmin" runat ="server" />
                    <asp:TextBox ID ="NameDate" CssClass="textboxadmin" runat ="server" />
                    <asp:TextBox ID ="DescriptionData" CssClass="textboxadmin" runat ="server" />
                    <asp:TextBox ID ="PriceData" CssClass="textboxadmin"  runat ="server" />

                </div>
            </div>
             <div class="botonesadmin">
                <asp:Button  runat="server" CssClass="botonadmin" Text="CREATE NEW PACK" OnClick="CrearClick"></asp:Button>
                <asp:Button  runat="server" CssClass="botonadmin" Text="UPDATE PACK" OnClick="UpdateClick"></asp:Button>
                <asp:Button  runat="server" CssClass="botonadmin" Text="DELETE PACK" OnClick="DeleteClick"></asp:Button>
             </div>
              <div class="texto">
                <asp:Label ID="output" runat="server"></asp:Label><br/> 

                <p> To create a new pack you MUST insert all the information. To update an existing one, you have to put the ID of the one you want to edit and its new price or/and description. To delete, just put the ID.</p>
              </div>


        </div>
</asp:Content>
