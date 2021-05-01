<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Room.aspx.cs" Inherits="JiltonWeb.Room" %>

    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link href="css/room.css" rel="stylesheet">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">

        <div class="background" >

            <div class="blurryBackground">

                <div class="plainBackground">

                    <div> class="ordenar" 
                         <asp:Label ID="Order" CssClass ="ilyan"> Order </asp:Label>

                    <asp:DropDownList ID="DropDownList1" runat="server">
                                    <asp:ListItem Value=0>Rating</asp:ListItem>
                                    <asp:ListItem Value=1>Price (lowest first)</asp:ListItem>
                                    <asp:ListItem Value=2>Price (highest first)</asp:ListItem>
                    </asp:DropDownList>
                    </div>
               

        <asp:DropDownList ID="Type" runat="server">
                        <asp:ListItem Value=0>Single</asp:ListItem>
                        <asp:ListItem Value=1>Double</asp:ListItem>
                        <asp:ListItem Value=2>Triple</asp:ListItem>
                        <asp:ListItem Value=3>Deluxe</asp:ListItem>
                        <asp:ListItem Value=4>Executive</asp:ListItem>
                        <asp:ListItem Value=5>Presidential</asp:ListItem>
        </asp:DropDownList>

    </asp:Content>


