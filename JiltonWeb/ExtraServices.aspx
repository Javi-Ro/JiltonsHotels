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
                                        Hola
                                    </Header>
                                    <Content>
                                        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" DataKeyNames="id">
                                            <EditItemTemplate>
                                                <span style="">id:
                                                    <asp:Label Text='<%# Eval("id") %>' runat="server" ID="idLabel1" /><br />
                                                    nombre:
                                                    <asp:TextBox Text='<%# Bind("nombre") %>' runat="server" ID="nombreTextBox" /><br />
                                                    nif:
                                                    <asp:TextBox Text='<%# Bind("nif") %>' runat="server" ID="nifTextBox" /><br />
                                                    edad:
                                                    <asp:TextBox Text='<%# Bind("edad") %>' runat="server" ID="edadTextBox" /><br />
                                                    <asp:Button runat="server" CommandName="Update" Text="Actualizar" ID="UpdateButton" /><asp:Button runat="server" CommandName="Cancel" Text="Cancelar" ID="CancelButton" /><br />
                                                    <br />
                                                </span>
                                            </EditItemTemplate>
                                            <EmptyDataTemplate>
                                                <span>No se han devuelto datos.</span>
                                            </EmptyDataTemplate>
                                            <InsertItemTemplate>
                                                <span style="">nombre:
                                                    <asp:TextBox Text='<%# Bind("nombre") %>' runat="server" ID="nombreTextBox" /><br />
                                                    nif:
                                                    <asp:TextBox Text='<%# Bind("nif") %>' runat="server" ID="nifTextBox" /><br />
                                                    edad:
                                                    <asp:TextBox Text='<%# Bind("edad") %>' runat="server" ID="edadTextBox" /><br />
                                                    <asp:Button runat="server" CommandName="Insert" Text="Insertar" ID="InsertButton" /><asp:Button runat="server" CommandName="Cancel" Text="Borrar" ID="CancelButton" /><br />
                                                    <br />
                                                </span>
                                            </InsertItemTemplate>
                                            <ItemTemplate>
                                                <span style="">id:
                                                    <asp:Label Text='<%# Eval("Id") %>' runat="server" ID="idLabel" /><br />
                                                    nombre:
                                                    <asp:Label Text='<%# Eval("Nombre") %>' runat="server" ID="nombreLabel" /><br />
                                                    nif:
                                                    <asp:Label Text='<%# Eval("Nif") %>' runat="server" ID="nifLabel" /><br />
                                                    edad:
                                                    <asp:Label Text='<%# Eval("Edad") %>' runat="server" ID="edadLabel" /><br />
                                                    <asp:Button runat="server" Text="holaa"/>
                                                    <br />
                                                    
                                                </span>
                                            </ItemTemplate>
                                            <LayoutTemplate>
                                                <div runat="server" id="itemPlaceholderContainer" style=""><span runat="server" id="itemPlaceholder" /></div>
                                                <div style="">
                                                </div>
                                            </LayoutTemplate>
                                            <SelectedItemTemplate>
                                                <span style="">id:
                                                    <asp:Label Text='<%# Eval("id") %>' runat="server" ID="idLabel" /><br />
                                                    nombre:
                                                    <asp:Label Text='<%# Eval("nombre") %>' runat="server" ID="nombreLabel" /><br />
                                                    nif:
                                                    <asp:Label Text='<%# Eval("nif") %>' runat="server" ID="nifLabel" /><br />
                                                    edad:
                                                    <asp:Label Text='<%# Eval("edad") %>' runat="server" ID="edadLabel" /><br />
                                                    <br />
                                                </span>
                                            </SelectedItemTemplate>
                                        </asp:ListView>
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
