<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="SpaGym.aspx.cs" Inherits="JiltonWeb.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="csslink" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <h1 align="center"><b> SPA </b></h1>
    <br />
    <div> </div>
    <asp:Label runat="server" align="center" cssClass="infospa" >Here you will find information of our Spa & Gym services and reservations</asp:Label>
    <img src ="assets/piscinaspajpg.jpg" class ="PiscinaSpa"/>
    <asp:Label runat="server" align="center">The relaxing spa's pool</asp:Label>
    <asp:Button ID="ReserSpaPool" runat="server" Text="Reserve" CssClass="reserva" />
    <br />
    <img src ="assets/jacuzzispa.jpg" class="JacSpa"/>
    <asp:Label runat="server" align="center">Jacuzzi with 100 water modes</asp:Label>
    <asp:Button ID="ReserSpaJac" runat="server" Text="Reserve" CssClass="reserva"/>
    <br />
    <img src="assets/spamasajes.jpg" class="SpaMas"/>
    <asp:Label runat="server" align="center">Multiple massages from different cultures</asp:Label>
    <asp:Button ID="ReserSpaMas" runat="server" Text="Reserve" CssClass="reserva"/>
    <br />
    <img src="assets/spatratestres.jpg" class="TratSpa"/>
    <asp:Label runat="server" align="center">Relaxing anti-stress treatments</asp:Label>
    <asp:Button ID="ReserSpaTrat" runat="server" Text="Reserve" CssClass="reserva"/>
    <br />
    <h1 align="center"><b>GYM</b></h1>
    <br />
    <asp:Label runat="server" align="center">The gym section where you will find one of the best gymnasiums of the city</asp:Label>
    <img src="assets/gimnasioporfuera.jpg" class="GymOut"/>
    <img src="assets/gympool.jpg" class="GymPool"/>
    <asp:Label runat="server" align="center">Olympic pool</asp:Label>
    <asp:Button ID="ReserGymPool" runat="server" Text="Reserve" CssClass="reserva"/>
    <br />
    <img src="assets/gimnasiopesas.jpg" class="GymPesas"/>
    <img src="assets/maquinascorrer.jpg" class="GymMaquinas"/>
    <asp:Label runat="server" align="center">Equiped gymnasium with all you need to get in shape</asp:Label>
    <asp:Button ID="ReserGymMaq" runat="server" Text="Reserve" CssClass="reserva"/>
    <br />
        
    
</asp:Content>
