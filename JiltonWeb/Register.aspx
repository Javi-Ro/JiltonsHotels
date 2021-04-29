<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="JiltonWeb.Register" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitlePage" runat="server">
    <title> Jilton Hotel - Register </title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="css/register.css" rel="stylesheet" />
    <div class="RegisterForm">
        <div class="row">
            <asp:Label runat="server" Width="59%">Name:</asp:Label>
            <asp:TextBox ID ="NameText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" runat ="server" />
        </div>

        <div class="row">
            <asp:Label runat="server" Width="59%">Surname:</asp:Label>
            <asp:TextBox ID ="SurnameText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" runat ="server" />
        </div>

        <div class="row">
            <asp:Label runat="server" Width="59%">DNI/NIF:</asp:Label>
            <asp:TextBox ID ="IDText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" runat ="server" />
        </div>

        <div class="row">
            <asp:Label runat="server" Width="59%">Date of Birth:</asp:Label>
            <asp:TextBox ID ="AgeText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" ReadOnly="true" runat ="server" />
            <ajax:CalendarExtender ID="BirthCalendar" runat="server" TargetControlID="AgeText" Format="dd/MM/yyyy"> </ajax:CalendarExtender>
        </div>

        <div class="row">
            <asp:Label runat="server" Width="59%">Mail:</asp:Label>
            <asp:TextBox ID ="MailText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" runat ="server" />
        </div>

        <div class="row">
            <asp:Label runat="server" Width="59%">Password:</asp:Label>
            <asp:TextBox ID ="PasswordText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" TextMode="Password" runat ="server" />
        </div>

        <div class="row">
            <asp:Label runat="server" Width="59%">Address:</asp:Label>
            <asp:TextBox ID ="AddressText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" runat ="server" />
        </div>

        <div class="row">
            <asp:Label runat="server" Width="59%">City:</asp:Label>
            <asp:TextBox ID ="CityText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" runat ="server" />
        </div>

        <div class="row">
            <asp:Label runat="server" Width="59%">Postal Code:</asp:Label>
            <asp:TextBox ID ="PCText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" runat ="server" />
        </div>

        <div class="row">
            <asp:Label runat="server" Width="59%">Province:</asp:Label>
            <asp:TextBox ID ="ProvinceText" CssClass="col" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; margin-right:2px" runat ="server" />
        </div>
    </div>
</asp:Content>
