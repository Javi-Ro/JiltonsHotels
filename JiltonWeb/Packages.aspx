<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Packages.aspx.cs" Inherits="JiltonWeb.Packages" %>

<asp:Content ID="cssLink" ContentPlaceHolderID="cssLink" runat="server">
    <link rel="stylesheet" href="../css/packages.css?ver=<?php echo rand(140,999)?>" />
    <link href="https://fonts.googleapis.com/css2?family=IM+Fell+Double+Pica:ital@1&display=swap" rel="stylesheet">
    <style type="text/css">
        .PackDesc {
            height: 50px;
            margin-left: 485px;
        }
        .Header {
            margin-left: 576px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="PackPlace">
        <div class="PackImage">
            <img src="assets/Placer.jpg" style="height: 362px; width: 357px" />
        </div>
        <div class="PackDesc">
            <h1 class="Header">Pleasure</h1>
            1 masaje (a elegir) + 1 sesión de spa diarios
            Con este pack será imposible no desconectar de la rutina
        </div>
    </div>
    <div class="PackPlace2">
        <div class="PackImage">
            <img  src="assets/Familia.jpg"/>
        </div>
        <div class="PackDesc">
            <h1 class="Header">Family</h1>
            Excursiones casi todos los días y salidas de acampada, 
            ideal para familia con niños

        </div>
    </div>
    <div class="PackPlace">
        <div class="PackImage">
            <img src="assets/Para2.jpg" style="height: 328px; width: 465px; margin-right: 0px" />
        </div>
        <div class="PackDesc">
            <h1 class="Header">Couple</h1>
            GUARRREOOO
        </div>
    </div>
    <div class="PackPlace2">
        <div class="PackImage">
            <img src="assets/Placer.jpg" />
        </div>
        <div class="PackDesc">
            <h1 class="Header">IDK</h1>
        </div>
    </div>
</asp:Content>
