<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="JiltonWeb.Register" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="cssLink" ContentPlaceHolderID="cssLink" runat="server">
    <link href="css/register.css" rel="stylesheet" />
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Karla&display=swap" rel="stylesheet">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="RegisterBack">
        <div class="fix"></div>
        <div class="RegisterLessOpacity">
            <div class="RegisterEntry">
                <div class="fix2">
                    <img src="../assets/jiltonLogo2.png"/>
                    <h1 class="HotelName">JILTON HOTEL RESORT & SPA CENTER</h1>
                    <h2 class="HotelName">REGISTRATION FORM</h2>
                </div>
                <div class="RegisterForm">
                    <div class="row">
                        <asp:Label runat="server" Width="35%">Name* :</asp:Label>
                        <asp:TextBox ID ="NameText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" runat ="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" CssClass="Validator" runat="server" ValidationGroup="RegisterInfoGroup" ErrorMessage="Name is required" ControlToValidate="NameText" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>

                    <div class="row">
                        <asp:Label runat="server" Width="35%">Surname* :</asp:Label>
                        <asp:TextBox ID ="SurnameText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" runat ="server" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorSurname" CssClass="Validator" runat="server" ValidationGroup="RegisterInfoGroup" ErrorMessage="Surname is required" ControlToValidate="SurnameText" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>

                    <div class="row">
                        <asp:Label runat="server" Width="35%">DNI/NIF* :</asp:Label>
                        <asp:TextBox ID ="IDText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" runat ="server" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorDNI" CssClass="Validator" runat="server" ValidationGroup="RegisterInfoGroup" ErrorMessage="DNI/NIF is required" ControlToValidate="IDText" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>

                    <div class="row">
                        <asp:Label runat="server" Width="35%">Date of Birth* :</asp:Label>
                        <asp:TextBox ID ="AgeText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" ReadOnly="true" runat ="server" />
                        <ajax:CalendarExtender ID="BirthCalendar" runat="server" TargetControlID="AgeText" Format="dd/MM/yyyy"> </ajax:CalendarExtender>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorBirthday" CssClass="Validator" runat="server" ValidationGroup="RegisterInfoGroup" ErrorMessage="Date of birth is required" ControlToValidate="AgeText" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>

                    <div class="row">
                        <asp:Label runat="server" Width="35%">Mail* :</asp:Label>
                        <asp:TextBox ID ="MailText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" runat ="server" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorMail" CssClass="Validator" runat="server" ValidationGroup="RegisterInfoGroup" ErrorMessage="E-mail is required" ControlToValidate="MailText" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>

                    <div class="row">
                        <asp:Label runat="server" Width="35%">Password* :</asp:Label>
                        <asp:TextBox ID ="PasswordText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" TextMode="Password" runat ="server" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" CssClass="Validator" runat="server" ValidationGroup="RegisterInfoGroup" ErrorMessage="Password is required" ControlToValidate="PasswordText" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>

                    <div class="row">
                        <asp:Label runat="server" Width="35%">Address:</asp:Label>
                        <asp:TextBox ID ="AddressText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" runat ="server" />
                    </div>

                    <div class="row">
                        <asp:Label runat="server" Width="35%">City:</asp:Label>
                        <asp:TextBox ID ="CityText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" runat ="server" />
                    </div>

                    <div class="row">
                        <asp:Label runat="server" Width="35%">Postal Code:</asp:Label>
                        <asp:TextBox ID ="PCText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" runat ="server" />
                    </div>

                    <div class="row">
                        <asp:Label runat="server" Width="35%">Province:</asp:Label>
                        <asp:TextBox ID ="ProvinceText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" runat ="server" />
                    </div>

                    <div class="row">
                        <asp:Hyperlink ID="GoToLoginFromRegister" runat="server" Width="35%" Text="Already have an account?" NavigateUrl="Login.aspx"/>
                        <asp:Button CssClass="RegisterBttn" Text="Register" runat="server" OnClick="Register_User" ValidationGroup="RegisterInfoGroup"/>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
