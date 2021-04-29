<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Packages.aspx.cs" Inherits="JiltonWeb.Packages" %>

<asp:Content ID="cssLink" ContentPlaceHolderID="cssLink" runat="server">
    <link rel="stylesheet" href="../css/packages.css?ver=<?php echo rand(145,999)?>" />
    <link href="https://fonts.googleapis.com/css2?family=IM+Fell+Double+Pica:ital@1&display=swap" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<p><code>wrapAround: true</code></p>

<!-- Flickity HTML init -->
<div class="gallery js-flickity"
  data-flickity-options='{ "wrapAround": true }'>
  <div class="gallery-cell">
      <img  src="assets/trainer.jpeg" /></div>
  <div class="gallery-cell">
      <img  src="assets/trainer.jpeg" /></div>
  <div class="gallery-cell">
      <img  src="assets/trainer.jpeg" /></div>
  <div class="gallery-cell"></div>
  <div class="gallery-cell"></div>
</div>
</asp:Content>
