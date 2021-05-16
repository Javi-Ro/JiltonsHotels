<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="ExtraServices.aspx.cs" Inherits="JiltonWeb.ExtraServices" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cssLink" runat="server">
    <link rel="stylesheet" href="../css/extraServices.css?ver=<?php echo rand(255,950)?>" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBPrueba.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Usuarios]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBPrueba.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT id FROM [Usuarios]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBPrueba.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT nif FROM [Usuarios]"></asp:SqlDataSource>
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
                            ContentCssClass="AccordionContent">
                            <Panes>
                                <ajaxToolkit:AccordionPane ID="AccordionPane1" runat="server" HeaderCssClass="AccordionHeader" ContentCssClass="AccordionContent">
                                    <Header>
                                        SPA
                                    </Header>
                                    <Content>
                                         <asp:GridView ID="GridViewServices" CssClass="grid" runat="server" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false" CellSpacing="8" ShowHeader="False" Width="100%" RowStyle-HorizontalAlign="Left"
                                            OnRowCommand="GridView_ButtonCommand">
                                            <Columns>
                                                <asp:BoundField DataField="description" ItemStyle-Width="150px"  ItemStyle-Font-Bold="true" />
                                                <asp:BoundField DataField="serviceDay" DataFormatString="{0:M}" ItemStyle-Font-Italic="true" ItemStyle-Width="50px" />
                                                <asp:BoundField DataField="price" DataFormatString="{0:C}" ItemStyle-Width="80px" />
                                                <asp:ButtonField Text="Delete" ButtonType="Link" ControlStyle-CssClass="GridButton"></asp:ButtonField>
                                            </Columns>
                                        </asp:GridView>
                                    </Content>
                                </ajaxToolkit:AccordionPane>
                            </Panes>
                        </ajaxToolkit:Accordion>
                        
                    </div>
                </div>
            </div>

            <aside class="BookingResume">
            </aside>
        </div>
    </div>
</asp:Content>
