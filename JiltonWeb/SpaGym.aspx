<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="SpaGym.aspx.cs" Inherits="JiltonWeb.WebForm2" %>

<asp:Content ID="cssLink" ContentPlaceHolderID="cssLink"  runat="server">
    <link rel="stylesheet" href="../css/spagym.css?ver=<?php echo rand(99,999)?>" />
    <link href="https://fonts.googleapis.com/css2?family=IM+Fell+Double+Pica:ital@1&display=swap" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 

    <div class="total">

        <div class="spa">
            <div class="titulo1">
                <h1 align="center"><b> ASIAN SPA </b></h1>
            </div>  
            <br />

            <div class="spatitulo">
                <asp:Label runat="server" align="center" CssClass="infospa1" >Here you will find information about our Spa & Gym services and reservations</asp:Label>
            </div>

            <div class="fotopiscispa">
                <img src ="assets/spapiscina.jpg" class ="PiscinaSpa"/>
            </div>

            <div class="piscina1">
                <asp:Label runat="server" CssClass="infospa">The relaxing spa's pool</asp:Label>
                <br />
                <asp:Button ID="ReserSpaPool" runat="server" Text="RESERVE" CssClass="reserva" />
            </div> 
            <br />

            <div class="fotojac">
                <img src ="assets/jacuzzispa.jpg" class="JacSpa"/>
            </div>

            <div class="jacuzzi">
                <asp:Label runat="server"  CssClass="infospa3">Jacuzzi with 100 water modes</asp:Label>
                <br />
                <asp:Button ID="ReserSpaJac" runat="server" Text="RESERVE" CssClass="reserva"/>
            </div> 
            <br />

            <div class="fotomasaje">
                <img src="assets/masspa.jpg" class="SpaMas"/> 
            </div>

            <div class="masajes">
                <asp:Label runat="server" CssClass="infospa2">Multiple massages from different cultures</asp:Label>
                <br />
                <asp:Button ID="ReserSpaMas" runat="server" Text="RESERVE" CssClass="reserva"/>
            </div>
            <br />

            <div class="fototrat">
                <img src="assets/masajes.png" class="TratSpa"/>
            </div>

            <div class="tratamientos"> 
                <br />
                <asp:Label runat="server" CssClass="infospa4">Relaxing anti-stress treatments</asp:Label>
                <br />
                <asp:Button ID="ReserSpaTrat" runat="server" Text="RESERVE" CssClass="reserva"/>
            </div>
            <br />

        </div>

        <div class="gym">
            <div class="titulo2">
                <h1 align="center"><b> GYM </b></h1>
            </div>
            <br />

            <div class="gym1">
                <asp:Label runat="server" CssClass="infospa5">The gym section where you will find one of the best gymnasiums of the city</asp:Label>
                <br />
            </div>
            <br />

            <div class="fotopsicigym">
                <img src="assets/gympool.jpg" class="GymPool"/>
            </div>

            <div class="piscina2">
                <asp:Label runat="server" CssClass="infospa6">Olympic pool</asp:Label>
                <br />
                <asp:Button ID="ReserGymPool" runat="server" Text="RESERVE" CssClass="reserva"/>
            </div>
            <br />

            <div class="fotomaquinas">
                <img src="assets/gimnasiopesas.jpg" class="GymPesas"/>
            </div>

            <div class="maquinas">
                <asp:Label runat="server" CssClass="infospa7">Equiped gymnasium with all you need to get in shape</asp:Label>
                <br />
                <asp:Button ID="ReserGymMaq" runat="server" Text="RESERVE" CssClass="reserva"/>
            </div>

        </div>
    </div>
            
</asp:Content>
