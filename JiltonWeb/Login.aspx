﻿<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="JiltonWeb.Login" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="cssLink" ContentPlaceHolderID="cssLink" runat="server">
    <link href="css/login.css" rel="stylesheet" />
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Karla&display=swap" rel="stylesheet">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="LoginBack">
        <div class="fix"></div>
        <div class="LoginLessOpacity">
            <div class="LoginEntry">
                <div class="fix2">
                    <img src="../assets/jiltonLogo2.png"/>
                    <h1 class="HotelName">JILTON HOTEL RESORT & SPA CENTER</h1>
                    <h2 class="HotelName">USER AUTHENTICATION</h2>
                </div>
                <div class="LoginForm">
                        <div class="row">
                            <asp:Label runat="server" Width="35%">E-mail:</asp:Label>
                            <asp:TextBox ID ="DataLoginText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" runat ="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorLoginDNI" CssClass="Validator" runat="server" ValidationGroup="LoginInfoGroup" ErrorMessage="DNI/NIF or email is required" ControlToValidate="DataLoginText" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>

                        <div class="row">
                            <asp:Label runat="server" Width="35%">Password:</asp:Label>
                            <asp:TextBox ID ="PasswordTextLogin" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" TextMode="Password" runat ="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorLoginPassword" CssClass="Validator" runat="server" ValidationGroup="LoginInfoGroup" ErrorMessage="Password is required" ControlToValidate="PasswordTextLogin" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>

                        <div class="row">
                            <asp:Hyperlink ID="GoToLoginFromRegister" runat="server" Width="35%" Text="Don't have an account yet?" NavigateUrl="Register.aspx"/>
                            <asp:Button CssClass="LoginBttn" ValidationGroup="LoginInfoGroup" Text="Login" OnClick="Login_User" runat="server" />
                            <asp:Panel ID="NoExistslbl" runat="server" CssClass="hideNoExistslbl">
                                <asp:Label runat="server" Text="E-mail not found. <a href='Register.aspx'> Create an account </a>" />
                            </asp:Panel>
                            <asp:Panel ID="WrongPsswd" runat="server" CssClass="hideWrongPsswd">
                                <asp:Label runat="server" Text="Incorrect password. Try again" />
                            </asp:Panel>
                        </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
