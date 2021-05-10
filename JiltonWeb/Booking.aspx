<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="JiltonWeb.Booking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cssLink" runat="server">
        <link rel="stylesheet" href="../css/booking.css?ver=<?php echo rand(21,950)?>" />
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
                    <asp:Image runat="server" class="cardImg" src="../assets/VisaCard.png"/>
                    <asp:Image runat="server" class="cardImg" src="../assets/MasterCard.png"/>
                    <asp:Image runat="server" class="cardImg" src="../assets/AmexCard.png"/>
                </div>
                <div class="PaymentForm">
                    <div class="Block">
                        <asp:TextBox id="CardNumber" CssClass="PaymentTextBox" placeholder="Card Number" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorCardNumber" CssClass="Validator" runat="server" ErrorMessage="Card number is required" ControlToValidate="CardNumber"></asp:RequiredFieldValidator>
                    </div>
                    <div class="Block">
                        <asp:TextBox id="ExpirationDate" CssClass="PaymentTextBox" placeholder="Expiration Date" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorDate" CssClass="Validator" runat="server" ErrorMessage="Expiration date is required" ControlToValidate="ExpirationDate"></asp:RequiredFieldValidator>
                    </div>
                    <div class="Block">
                        <asp:TextBox id="CVV" CssClass="PaymentTextBox" placeholder="CVV" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorCVV" CssClass="Validator" runat="server" ErrorMessage="CVV is required" ControlToValidate="CVV"></asp:RequiredFieldValidator>
                    </div>
                    <div class="Block">
                        <asp:TextBox id="TitularName" CssClass="PaymentTextBox" placeholder="Titular Name" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorTitularName" CssClass="Validator" runat="server" ErrorMessage="Titular name is required" ControlToValidate="TitularName"></asp:RequiredFieldValidator>
                    </div>
                    
                </div>
                <asp:Button runat="server" CssClass="PaymentButton" Text="PAY NOW" Enabled="False" />
            </div>
            </div>
            <aside class="BookingResume">

            </aside>
        </div>
    </div>
</asp:Content>
