<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="JiltonWeb.Booking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cssLink" runat="server">
        <link rel="stylesheet" href="../css/booking.css?ver=<?php echo rand(210,950)?>" />
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
                    <asp:Image runat="server" class="cardImg" ID="VisaCard" src="../assets/VisaCard.png"/>
                    <asp:Image runat="server" class="cardImg" ID="MasterCard" src="../assets/MasterCard.png"/>
                    <asp:Image runat="server" class="cardImg" ID="AmexCard" src="../assets/AmexCard.png"/>
                </div>
                <div class="PaymentForm">
                    <div class="Block">
                        <asp:TextBox id="CardNumber" CssClass="PaymentTextBox" placeholder="Card Number*" runat="server" MaxLength=20 OnTextChanged="OnTextChanged_Card"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorCardNumber" CssClass="Validator" runat="server" ErrorMessage="Card number is required" ControlToValidate="CardNumber" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorCardVisa" CssClass="Validator" runat="server" ErrorMessage="Invalid Card Number" ValidationExpression="^(?:4[0-9]{12}(?:[0-9]{3})?|(?:5[1-5][0-9]{2}|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[01][0-9]|2720)[0-9]{12}|3[47][0-9]{13})$" ControlToValidate="CardNumber" Display="Dynamic"></asp:RegularExpressionValidator>
                    </div>
                    <div class="Block">
                        <asp:TextBox id="ExpirationDate" CssClass="PaymentTextBox" placeholder="Expiration Date* (mm/yyyy)" runat="server" MaxLength="7"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorDate" CssClass="Validator" runat="server" ErrorMessage="Invalid Expiration date" ValidationExpression="\d{2}/\d{4}" ControlToValidate="ExpirationDate" Display="Dynamic"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorDate" CssClass="Validator" runat="server" ErrorMessage="Expiration date is required" ControlToValidate="ExpirationDate" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                    <div class="Block">
                        <asp:TextBox id="CVV" CssClass="PaymentTextBox" placeholder="CVV*" runat="server" MaxLength="3"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorCVV" CssClass="Validator" runat="server" ErrorMessage="Invalid CVV code" ValidationExpression="\d{3}" ControlToValidate="CVV" Display="Dynamic"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorCVV" CssClass="Validator" runat="server" ErrorMessage="CVV is required" ControlToValidate="CVV"></asp:RequiredFieldValidator>
                    </div>
                    <div class="Block">
                        <asp:TextBox id="TitularName" CssClass="PaymentTextBox" placeholder="Titular Name*" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorTitularName" CssClass="Validator" runat="server" ErrorMessage="Titular name is required" ControlToValidate="TitularName"></asp:RequiredFieldValidator>
                    </div>
                    
                </div>
                <asp:Button runat="server" CssClass="PaymentButton" Text="PAY NOW" />
            </div>
            </div>
            <aside class="BookingResume">

            </aside>
        </div>
    </div>
</asp:Content>
