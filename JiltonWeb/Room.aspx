<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Room.aspx.cs" Inherits="JiltonWeb.Room" %>

    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link href="room.css" rel="stylesheet">
        <asp:Label ID="rosa" CssClass ="ilyan"> holaaa</asp:Label>
        <asp:DropDownList ID="Order" runat="server">
                        <asp:ListItem Value=0>Rating</asp:ListItem>
                        <asp:ListItem Value=1>Price (lowest first)</asp:ListItem>
                        <asp:ListItem Value=2>Price (highest first)</asp:ListItem>
        </asp:DropDownList>

        <asp:DropDownList ID="Type" runat="server">
                        <asp:ListItem Value=0>Single</asp:ListItem>
                        <asp:ListItem Value=1>Double</asp:ListItem>
                        <asp:ListItem Value=2>Triple</asp:ListItem>
                        <asp:ListItem Value=3>Deluxe</asp:ListItem>
                        <asp:ListItem Value=4>Executive</asp:ListItem>
                        <asp:ListItem Value=5>Presidential</asp:ListItem>
        </asp:DropDownList>

    </asp:Content>


