<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="ExtraServices.aspx.cs" Inherits="JiltonWeb.ExtraServices" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cssLink" runat="server">
    <link rel="stylesheet" href="../css/extraServices.css?ver=<?php echo rand(255,950)?>" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBPrueba.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Usuarios]"></asp:SqlDataSource>
    <div class="MainContainerBooking">
        <div class="CenteredContainer">
            <div class="BorderMainBlock">
                <div class="MainBlock">
                    <div class="HeaderBlock">
                        <h1 class="ExtraServicesLabel">ADD EXTRA SERVICES</h1>
                    </div>
                    <div class="ServicesContainer">
                        <ajaxToolkit:Accordion 
                            ID="ServicesAccordion" runat="server" AutoSize="None" FadeTransitions="true" SuppressHeaderPostbacks="true" 
                            RequireOpenedPane="false" FramesPerSecond="40" TransitionDuration="250" SelectedIndex=0 HeaderCssClass="AccordionHeader"
                            ContentCssClass="AccordionContent" DataSourceID="SqlDataSource1">
                            <HeaderTemplate>
                                <header>> Hola buenas </header>
                            </HeaderTemplate>
                            <ContentTemplate>
                                <Content>
                                        dsfasdfadfasdfdfdfsdafadfasdfadfasdfsaaaaaaaaaa dfasdfdasjfklasdjf kasdfkljdkfasdklfjdfdsaf asjfjd ad fkl asfkfkas dfjaf adsfasdf
                                        asdfsda jfldksfjkjsdakfj aslñfkld kfjadskf kdfsdkfds fdkfdjkfsdfka  kfasdjfka fkladff dklfeioriuwqerncvmd,sfmkdfjaksdfd dskfjdskfjlkf
                                </Content>
                            </ContentTemplate>
                        </ajaxToolkit:Accordion>
                        
                    </div>
                </div>
            </div>
            <aside class="BookingResume">
            </aside>
        </div>
    </div>
</asp:Content>
