<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="SpaGym.aspx.cs" Inherits="JiltonWeb.WebForm2" %>

<asp:Content ID="cssLink" ContentPlaceHolderID="cssLink"  runat="server">
    <link rel="stylesheet" href="../css/spagym.css?ver=<?php echo rand(99,999)?>" />
    <link href="https://fonts.googleapis.com/css2?family=IM+Fell+Double+Pica:ital@1&display=swap" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    
    <h1 align="center"><b> SPA </b></h1>
    <br />
    <asp:Label runat="server" align="center" CssClass="infospa" >Here you will find information of our Spa & Gym services and reservations</asp:Label>
    <img src ="assets/piscinaspajpg.jpg" class ="PiscinaSpa"/>
    <br />
    <asp:Label runat="server" align="center" CssClass="infospa">The relaxing spa's pool</asp:Label>
    <br />
    <asp:Button ID="ReserSpaPool" runat="server" Text="Reserve" CssClass="reserva" />
    <br />
    <img src ="assets/jacuzzispa.jpg" class="JacSpa"/>
    <br />
    <asp:Label runat="server" align="center" CssClass="infospa">Jacuzzi with 100 water modes</asp:Label>
    <br />
    <asp:Button ID="ReserSpaJac" runat="server" Text="Reserve" CssClass="reserva"/>
    <br />
    <img src="assets/spamasajes.jpg" class="SpaMas"/>
    <br />
    <asp:Label runat="server" align="center" CssClass="infospa2">Multiple massages from different cultures</asp:Label>
    <br />
    <asp:Button ID="ReserSpaMas" runat="server" Text="Reserve" CssClass="reserva"/>
    <br />
    <img src="assets/spatratestres.jpg" class="TratSpa"/>
    <br />
    <asp:Label runat="server" align="center" CssClass="infospa">Relaxing anti-stress treatments</asp:Label>
    <br />
    <asp:Button ID="ReserSpaTrat" runat="server" Text="Reserve" CssClass="reserva"/>
    <br />
    <h1 align="center"><b>GYM</b></h1>
    <br />
    <asp:Label runat="server" align="center" CssClass="infospa">The gym section where you will find one of the best gymnasiums of the city</asp:Label>
    <br />
    <img src="assets/gimnasioporfuera.jpg" class="GymOut"/>
    <br />
    <img src="assets/gympool.jpg" class="GymPool"/>
    <br />
    <asp:Label runat="server" align="center" CssClass="infospa">Olympic pool</asp:Label>
    <br />
    <asp:Button ID="ReserGymPool" runat="server" Text="Reserve" CssClass="reserva"/>
    <br />
    <img src="assets/gimnasiopesas.jpg" class="GymPesas"/>
    <br />
    <img src="assets/maquinascorrer.jpg" class="GymMaquinas"/>
    <br />
    <asp:Label runat="server" align="center" CssClass="infospa">Equiped gymnasium with all you need to get in shape</asp:Label>
    <br />
    <asp:Button ID="ReserGymMaq" runat="server" Text="Reserve" CssClass="reserva"/>
    <br />
    <br />
    <br />
        
    
</asp:Content>
