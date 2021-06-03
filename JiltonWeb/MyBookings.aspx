<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="MyBookings.aspx.cs" Inherits="JiltonWeb.MyBookings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cssLink" runat="server">
    <link href="css/mybookings.css" rel="stylesheet" />
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Karla&display=swap" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="MyBookingsBack">
         <asp:GridView ID="GridView1"  CssClass="grid" runat="server" showHeader="false" AutoGenerateColumns="False">  
            <emptydatarowstyle CssClass="emptyRow"/>

                <pagersettings mode="Numeric"
                position="Bottom"           
                pagebuttoncount="10"/>
                      
            <pagerstyle horizontalalign="Center" height="30px" cssClass="paginacion"/>
                    
            <Columns >
 
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="booking">
                        <div class="row">
                            <div class="Informacion">
                                <asp:Label ID="Label2" runat="server"  CssClass="field"> <b>Entry date:</b> </asp:Label>
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("date_in") %>'> </asp:Label>
                                <br />
                                <br />
                                <asp:Label ID="Label4" runat="server"  CssClass="field"> <b>Departure date:</b> </asp:Label>
                                <asp:Label ID="Label5" runat="server" Text='<%# Eval("date_out") %>' >   </asp:Label>
                                <br />
                                <br />
                                <asp:Label ID="Label6" runat="server"  CssClass="field"> <b>Type of board:</b> </asp:Label>
                                <asp:Label ID="Label7" runat="server" Text='<%# Eval("board") %>' >   </asp:Label>
                                <br />
                                <br />
                                <asp:Label ID="Label8" runat="server"  CssClass="field"> <b>Total price:</b> </asp:Label>
                                <asp:Label ID="Label9" runat="server" Text='<%# Eval("price") %>' > </asp:Label>
                                €
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
                    
                     
        </asp:GridView>
    </div>
</asp:Content>
