<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="SpaGym.aspx.cs" Inherits="JiltonWeb.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitlePage" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <h1 align="center"><b> SPA </b></h1>
    <p>Here you will find information of our Spa & Gym services and reservations</p>
    <img src ="assets/piscinaspajpg.jpg"/>
    <p>The relaxing spa's pool</p>
    <asp:Button ID="ReserSpaPool" runat="server" Text="Reserve" />
    <img src ="assets/jacuzzispa.jpg"/>
    <p>Jacuzzi with 100 water modes</p>
    <asp:Button ID="ReserSpaJac" runat="server" Text="Reserve" />
    <img src="assets/spamasajes.jpg"/>
    <p>Multiple massages from different cultures</p>
    <asp:Button ID="ReserSpaMas" runat="server" Text="Reserve" />
    <img src="assets/spatratestres.jpg"/>
    <p>Relaxing anti-stress treatments</p>
    <asp:Button ID="ReserSpaTrat" runat="server" Text="Reserve" />
    <h1 align="center"><b>GYM</b></h1>
    <p>The gym section where you will find one of the best gymnasiums of the city</p>
    <img src="assets/gimnasioporfuera.jpg"/>
    <img src="assets/gympool.jpg"/>
    <p>Olympic pool</p>
    <asp:Button ID="ReserGymPool" runat="server" Text="Reserve" />
    <img src="assets/gimnasiopesas.jpg"/>
    <img src="assets/maquinascorrer.jpg" />
    <p>Equiped gymnasium with all you wish</p>
    <asp:Button ID="ReserGymMaq" runat="server" Text="Reserve" />
    
</asp:Content>
