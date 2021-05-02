<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="JiltonWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cssLink" runat="server">
        <link rel="stylesheet" href="../css/booking.css?ver=<?php echo rand(521,950)?>" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="MainContainerBooking">
        <div class="CenteredContainer">
            <div class="BorderMainBlock">
            <div class="MainBlock">
                <div class="HeaderBlock">
                    <h1 class="PaymentLabel">Payment Information</h1>
                </div>
                <div class="MethodContainer">
                    <asp:Label runat="server" CssClass="PaymentMethodLabel">Payment Method</asp:Label>
                    <asp:DropDownList ID="PaymentList" CssClass="PaymentMethodOption" runat="server"></asp:DropDownList>
                </div>
                <div class="CardImages">
                    <img class="cardImg" src="../assets/VisaCard.png"/>
                    <img class="cardImg" src="../assets/MasterCard.png"/>
                    <img class="cardImg" src="../assets/AmexCard.png"/>
                </div>
                <div class="PaymentForm">
                    <asp:TextBox id="CardNumber" CssClass="PaymentTextBox" placeholder="Card Number" runat="server"></asp:TextBox>
                    <asp:TextBox id="ExpirationDate" CssClass="PaymentTextBox" placeholder="Expiration Date" runat="server"></asp:TextBox>
                    <asp:TextBox id="CVV" CssClass="PaymentTextBox" placeholder="CVV" runat="server"></asp:TextBox>
                    <asp:TextBox id="TitularName" CssClass="PaymentTextBox" placeholder="Titular Name" runat="server"></asp:TextBox>
                </div>
                <asp:Button runat="server" CssClass="PaymentButton" Text="PAY NOW" Enabled="False" />
            </div>
            </div>
            <aside class="BookingResume">

            </aside>
        </div>
    </div>
</asp:Content>
