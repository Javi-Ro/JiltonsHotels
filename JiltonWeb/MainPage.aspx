<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="JiltonWeb.MainPage" %>

<asp:Content ID="cssLink" ContentPlaceHolderID="cssLink" runat="server">
    <link rel="stylesheet" href="../css/main.css?ver=<?php echo rand(275,999)?>" />
    <link href="https://fonts.googleapis.com/css2?family=IM+Fell+Double+Pica:ital@1&display=swap" rel="stylesheet">
</asp:Content>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Main">
        <div class="HomeContainer">
            <asp:Label CssClass="EntryLabel" runat="server">Welcome</asp:Label>
        </div>
        <div class="Comments">
            <div class="CommentsLessOpacity">
                <div class="CommentsLabels">
                    <img src="../assets/jiltonLogo2.png"/>
                    <h1 class="HotelName">JILTON HOTEL RESORT & SPA CENTER</h1>
                    <br />
                    <asp:Label runat="server" CssClass="Reason"> WHY STAYING AT JILTON HOTEL ?</asp:Label>
                
                    <p class="ReasonParagraph">Many celebrities chose Jilton Hotel to enjoy a unique retreat. This exclusive asiatic
                        oriented hotel is one of the best places to take pleasure of absolute relax and exquisite
                        service. Feel welcome to enjoy our exhuberant tropical gardens, along with 7 spectacular and peaceful pools 
                        -2 of them climatized-, our luxurious restaurant service and Gym&Spa facilities where you can lose the notion of the 
                        time and recover your energy</p>
                    <div class="ZidaneOpinion">
                        <asp:Label runat="server" CssClass="OpinionLabel">Many thanks for your simpathy and hospitality. A wonderful place in Spain!</asp:Label>
                        <div class="ZidaneContainer">
                            <asp:Label runat="server" CssClass="ZidaneLabel">ZINÉDINE ZIDANE</asp:Label>
                            <asp:Label runat="server" CssClass="ZidaneCoach">Football Coach</asp:Label>
                        </div>
                    </div>

                </div>
            </div>
        </div>
        <div class="ParadiseContainer">
            <asp:Label runat="server" CssClass="ParadiseLabel">An asiatic paradise on the mediterranean sea</asp:Label>
        </div>
        <div class="Blocks">
            <div class="SeparatorBlocks"></div>
            <div class="Block1">
                <div class="ImageB1"></div>
                <div class="TextB1">
                    <div class="CenterText">
                    <asp:Label CssClass="Text1" runat="server">DELUXE AND PEACEFUL, ONLY RELAX</asp:Label>
                    <asp:Label runat="server" CssClass="Text2">Thai Spa</asp:Label>
                    <asp:Label runat="server" CssClass="Text3">Complete your stay with a 100% asiatic experience.</asp:Label>
                    <p class="Text4">Book now your massage or treatment in one of the most relaxing places of Jilton Hotel and enjoy with our expert masseurs, well-educated in 
                        the most prestigious school of the world. Our recommendation is to book your massage at the afternoon to witness the peaceful sunset while
                        you get treated by our masseurs, creating a real harmony between your mind and body.</p>
                    <asp:Button runat="server" Text="BOOK NOW" CssClass="MainBookMassage" ID="SpaButton" OnClick="SpaButton_Click" />
                    </div>
                </div>
            </div>
            <div class="Block2">
                <div class="ImageB2"></div>
                <div class="TextB2">
                    <div class="CenterText">
                    <asp:Label CssClass="Text1" runat="server">EVENTS</asp:Label>
                    <asp:Label runat="server" CssClass="Text2">Convention Center</asp:Label>
                    <asp:Label runat="server" CssClass="Text3">Surprisintly and exclusive, the ideal place for your event.</asp:Label>
                    <p class="Text4">The exclusivity of a 5-star hotel with an exquisit service makes Jilton Hotel the ideal place to organize your event. Jilton Hotel offers
                        versatile areas that works perfectly in a lot of types of events and are thought to get the best of it. 
                    </p>
                    <asp:Button runat="server" Text="COMING SOON" CssClass="MainBookMassage2" ID="EventsButton" Enabled="False" OnClick="EventsButton_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

