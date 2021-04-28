<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="JiltonWeb.MainPage" %>

<asp:Content ID="cssLink" ContentPlaceHolderID="cssLink" runat="server">
    <link rel="stylesheet" href="../css/main.css?v=<?php echo time(); ?>" />
    <link href="https://fonts.googleapis.com/css2?family=IM+Fell+Double+Pica:ital@1&display=swap" rel="stylesheet">
</asp:Content>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Main">
        <div>
            <asp:Label CssClass="EntryLabel" runat="server">Te esperamos</asp:Label>
        </div>
        <div class="Comments">
            <div class="CommentsLessOpacity">
            <div class="CommentsLabels">
                <img src="../assets/jiltonLogo2.png"/>
                <h1 class="HotelName">JILTON HOTEL RESORT & SPA CENTER</h1>
                <br />
                <asp:Label runat="server" CssClass="Reason">¿ WHY STAYING ON JILTON HOTEL ?</asp:Label>
                <asp:Label runat="server" CssClass="Separator">_________________________________________________________________________</asp:Label>
                <p> A lot of famous people had chosen Jilton Hotel to enjoy of a unique trip. This exclusive asiatic
                    oriented hotel is one of the best places to take pleasure of the more absolute relax and exquisit
                    service. Its exhuberant tropical jardins, its 7 spectacular and peaceful pools 2 of them climatized,
                    its perfect restaurant service, its Gym&Spa where you can lose the notion of the time and recover your
                    energy are some of the reasons...</p>
            </div>
            </div>
        </div>
        
    </div>

</asp:Content>
