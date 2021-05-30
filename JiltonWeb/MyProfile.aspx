<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="MyProfile.aspx.cs" Inherits="JiltonWeb.MyProfile" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="cssLinks" ContentPlaceHolderID="cssLink" runat="server">
    <link href="css/myprofile.css" rel="stylesheet" />
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Karla&display=swap" rel="stylesheet">
</asp:Content>
<asp:Content ID="ContentMyProfile" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="backgroundProfile">
        <div id="blurryBack">
            <div id="nonBlurryBack">
                <div id="intro">
                    <img src="../assets/jiltonLogo2.png"/>
                    <h1 class="HotelName">JILTON HOTEL RESORT & SPA CENTER</h1>
                    <h2 class="HotelName">MY PROFILE</h2>
                </div>

                <asp:Panel runat="server" ID="onlyAdmin">
                    <h1 class="adminText">FOR SECURITY MEASURES</h1>
                    <h1 class="adminText2">ADMINISTRATORS CANNOT MODIFY THEIR ACCOUNT</h1>
                </asp:Panel>

                <asp:Panel ID="MyInfoPanel" runat="server">

                    <div id="bothFlex">
                        <div id="labelsFlex">
                            <asp:Label CssClass="labels" runat="server" Width="35%">Full name:</asp:Label>
                            <asp:Label CssClass="labels" runat="server" Width="35%">DNI/NIE:</asp:Label>
                            <asp:Label CssClass="labels" runat="server" Width="35%">E-mail:</asp:Label>
                            <asp:Label CssClass="labels" runat="server" Width="35%">Date of Birth:</asp:Label>
                            <asp:Label CssClass="labels" runat="server" Width="35%">Address:</asp:Label>
                            <asp:Label CssClass="labels" runat="server" Width="35%">New password:</asp:Label>
                            <asp:Label CssClass="labels" runat="server" Width="35%">Current password:</asp:Label>
                        </div>
                        <div id="textBoxFlex">
                            <asp:TextBox ID ="NameText" CssClass="nonModifiable" Text="" ReadOnly="true" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; padding: 0px 4px;" runat ="server" />
                            <asp:TextBox ID ="IDText" CssClass="nonModifiable" Text="" ReadOnly="true" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; padding: 0px 4px;" runat ="server" />
                            <asp:TextBox ID ="EmailText" CssClass="nonModifiable" Text="" ReadOnly="true" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; padding: 0px 4px;" runat ="server" />
                            <asp:TextBox ID ="AgeText" CssClass="nonModifiable" ReadOnly="true" Text="" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; padding: 0px 4px; margin-right:2px" OnKeyPress="return false;" AutoComplete="off" runat ="server" />          
                            <asp:TextBox ID ="AddressText" CssClass="modifiable" Text="" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; padding: 0px 4px;" runat ="server" />
                            <asp:TextBox ID ="NewPasswordText" CssClass="modifiable" TextMode="Password" Text="" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; padding: 0px 4px;" runat ="server" />
                            <asp:TextBox ID ="CurrentPasswordText" CssClass="modifiable" TextMode="Password" Text="" Height="30px" style="text-align:left; border-radius:3px; border-width:1px; padding: 0px 4px;" runat ="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" CssClass="Validator" runat="server" ValidationGroup="UpdateInfoGroup" ErrorMessage="Current password is required" ControlToValidate="CurrentPasswordText" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:Button runat="server" ID="incorrectPassword" CssClass="incorrectPass" OnClientClick="this.disabled=true;" Text="Incorrect password"/>
                        </div>
                    </div>
                    <asp:Button CssClass="DeleteAccountButton" runat="server" Text="Delete account" OnClick="DeleteAccount" ValidationGroup="UpdateInfoGroup"/>
                    <asp:Button CssClass="UpdateAccountButton" runat="server" Text="Update" OnClick="UpdateAccount" ValidationGroup="UpdateInfoGroup"/>
                </asp:Panel>
            </div>
        </div>
    </div>
</asp:Content>
