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

            <div class="spatitulo">
                <asp:Label runat="server" align="center" CssClass="infospa1" >Here you will find information about our Spa & Gym services and reservations</asp:Label>
            </div>
        
            <div class="fotopiscispa">
                <asp:Image runat="server" src ="assets/spapiscina.jpg" class ="PiscinaSpa"/>
            </div>
            <br />

            <div class="piscina1">
                <asp:Label runat="server" CssClass="infospa">The relaxing spa's pool - With 50 meters long you will enjoy a quite relaxing experience</asp:Label>
                <br />
                <br />
                <asp:Button ID="ReserSpaPool" runat="server" Text="RESERVE" CssClass="reserva" />
            </div> 
            <br />
            <br />

            <div class="fotojac">
                <asp:Image runat="server" src ="assets/jacuzzispa.jpg" class="JacSpa"/>
            </div>
            <br />

            <div class="jacuzzi">
                <asp:Label runat="server"  CssClass="infospa3">Jacuzzi - With 100 water modes desingned for a comfort time </asp:Label>
                <br />
                <br />
                <asp:Button ID="ReserSpaJac" runat="server" Text="RESERVE" CssClass="reserva"/>
            </div> 
            <br />

            <div class="fotomasaje">
                <asp:Image runat="server" src="assets/masspa.jpg" class="SpaMas"/> 
            </div>
            <br />

            <div class="masajes">
                <asp:Label runat="server" CssClass="infospa2">Massages - You make your massage´s choice between more than a hundred, and then just relax</asp:Label>
                <br />
                <br />
                <asp:Button ID="ReserSpaMas" runat="server" Text="RESERVE" CssClass="reserva"/>
            </div>
            <br />

            <div class="fototrat">
                <asp:Image runat="server" src="assets/masajes.png" class="TratSpa"/>
            </div>
            <br />

            <div class="tratamientos"> 
                <br />
                <asp:Label runat="server" CssClass="infospa4">Anti-stress treatments - Treatments for the people who really need to disconect from the world</asp:Label>
                <br />
                <br />
                <asp:Button ID="ReserSpaTrat" runat="server" Text="RESERVE" CssClass="reserva"/>
            </div>
            <br />

        </div>

        <div class="gym">
            <div class="titulo2">
                <h1 ><b> GYM </b></h1>
            </div>
            <br />

            <div class="gym1">
                <asp:Label runat="server" CssClass="infospa5">The gym section where you will find one of the best gymnasiums of the city</asp:Label>
                <br />
            </div>
            <br />

            <div class="fotopsicigym">
                <asp:Image runat="server" src="assets/gympool.jpg" class="GymPool"/>
            </div>
            <br />

            <div class="piscina2">
                <asp:Label runat="server" CssClass="infospa6">Olympic pool - The olympic pool with one of the best quality certificates</asp:Label>
                <br />
                <br />
                <asp:Button ID="ReserGymPool" runat="server" Text="RESERVE" CssClass="reserva"/>
            </div>
            <br />

            <div class="fotomaquinas">
                <asp:Image runat="server" src="assets/gimnasiopesas.jpg" class="GymPesas"/>
            </div>
            <br />

            <div class="maquinas">
                <asp:Label runat="server" CssClass="infospa7">Gymnasium - Machines and staff will make you so easy to get in shape</asp:Label>
                <br />
                <br />
                <asp:Button ID="ReserGymMaq" runat="server" Text="RESERVE" CssClass="reserva"/>
            </div>

        </div>
    </div>
            
</asp:Content>
