<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="ExtraServices.aspx.cs" Inherits="JiltonWeb.ExtraServices" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cssLink" runat="server">
    <link rel="stylesheet" href="../css/extraServices.css?ver=<?php echo rand(355,950)?>" />
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
                        <h1 class="ExtraServicesLabel">COMPLETE YOUR STAY WITH OUR SERVICES</h1>
                    </div>
                    <div class="ServicesContainer">
                        <div class="centeredAccordion">
                        <ajaxToolkit:Accordion 
                            ID="ServicesAccordion" runat="server" AutoSize="None" FadeTransitions="true" SuppressHeaderPostbacks="true" 
                            RequireOpenedPane="false" FramesPerSecond="40" TransitionDuration="250" SelectedIndex=0 HeaderCssClass="AccordionHeader"
                            ContentCssClass="AccordionContent" CssClass="Accordion" HeaderSelectedCssClass="SelectedHeaderAccordion">
                            <Panes>
                                <ajaxToolkit:AccordionPane ID="AccordionPane1" runat="server" HeaderCssClass="AccordionHeader" ContentCssClass="AccordionContent">
                                    <Header>
                                        <asp:Label runat="server" Text="SPA"></asp:Label>
                                    </Header>
                                    <Content>
                                         <asp:GridView ID="AccordionPaneSpa" CssClass="grid" runat="server" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false" CellSpacing="8" ShowHeader="False" Width="100%" RowStyle-HorizontalAlign="Left"
                                            OnRowCommand="GridView_ButtonCommand">
                                            <Columns>
                                                <asp:BoundField DataField="description" ItemStyle-Width="150px"  ItemStyle-Font-Bold="true" />
                                                <asp:BoundField DataField="price" DataFormatString="{0:C}" ItemStyle-Width="80px" />
                                                <asp:ButtonField Text="ADD" ButtonType="Link" ControlStyle-CssClass="GridButton"></asp:ButtonField>
                                            </Columns>
                                        </asp:GridView>
                                    </Content>
                                </ajaxToolkit:AccordionPane>
                                <ajaxToolkit:AccordionPane ID="AccordionPane3" runat="server" HeaderCssClass="AccordionHeader" ContentCssClass="AccordionContent">
                                    <Header>
                                        <asp:Label runat="server" Text="GYM"></asp:Label>
                                    </Header>
                                    <Content>
                                         <asp:GridView ID="AccordionPaneGym" CssClass="grid" runat="server" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false" CellSpacing="8" ShowHeader="False" Width="100%" RowStyle-HorizontalAlign="Left"
                                            OnRowCommand="GridView_ButtonCommand">
                                            <Columns>
                                                <asp:BoundField DataField="description" ItemStyle-Width="150px"  ItemStyle-Font-Bold="true" />
                                                <asp:BoundField DataField="price" DataFormatString="{0:C}" ItemStyle-Width="80px" />
                                                <asp:ButtonField Text="ADD" ButtonType="Link" ControlStyle-CssClass="GridButton"></asp:ButtonField>
                                            </Columns>
                                        </asp:GridView>
                                    </Content>
                                </ajaxToolkit:AccordionPane>
                                <ajaxToolkit:AccordionPane ID="AccordionPane4" runat="server" HeaderCssClass="AccordionHeader" ContentCssClass="AccordionContent">
                                    <Header>
                                        <asp:Label runat="server" Text="CAR LEASING"></asp:Label>
                                    </Header>
                                    <Content>
                                         <asp:GridView ID="AccordionPaneCars" CssClass="grid" runat="server" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false" CellSpacing="8" ShowHeader="False" Width="100%" RowStyle-HorizontalAlign="Left"
                                            OnRowCommand="GridView_ButtonCommand">
                                            <Columns>
                                                <asp:BoundField DataField="brand" ItemStyle-Width="50px"  ItemStyle-Font-Bold="true" />
                                                <asp:BoundField DataField="model" ItemStyle-Width="50px"  ItemStyle-Font-Italic="true" />
                                                <asp:BoundField DataField="price" DataFormatString="{0:C}" ItemStyle-Width="80px" />
                                                <asp:ButtonField Text="ADD" ButtonType="Link" ControlStyle-CssClass="GridButton"></asp:ButtonField>
                                            </Columns>
                                        </asp:GridView>
                                    </Content>
                                </ajaxToolkit:AccordionPane>
                                <ajaxToolkit:AccordionPane ID="AccordionPane2" runat="server" HeaderCssClass="AccordionHeader" ContentCssClass="AccordionContent">
                                    <Header>
                                        <asp:Label runat="server" Text="EXTRA SERVICES"></asp:Label>
                                    </Header>
                                    <Content>
                                         <asp:GridView ID="AccordionPaneExtra" CssClass="grid" runat="server" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false" CellSpacing="8" ShowHeader="False" Width="100%" RowStyle-HorizontalAlign="Left"
                                            OnRowCommand="GridView_ButtonCommand">
                                            <Columns>
                                                <asp:BoundField DataField="description" ItemStyle-Width="150px"  ItemStyle-Font-Bold="true" />
                                                <asp:BoundField DataField="price" DataFormatString="{0:C}" ItemStyle-Width="80px" />
                                                <asp:ButtonField Text="ADD" ButtonType="Link" ControlStyle-CssClass="GridButton"></asp:ButtonField>
                                            </Columns>
                                        </asp:GridView>
                                    </Content>
                                </ajaxToolkit:AccordionPane>
                                <ajaxToolkit:AccordionPane ID="AccordionPane5" runat="server" HeaderCssClass="AccordionHeader" ContentCssClass="AccordionContent">
                                    <Header>
                                        <asp:Label runat="server" Text="PACKAGES"></asp:Label>
                                    </Header>
                                    <Content>
                                         <asp:GridView ID="AccordionPanePackages" CssClass="grid" runat="server" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false" CellSpacing="8" ShowHeader="False" Width="100%" RowStyle-HorizontalAlign="Left"
                                            OnRowCommand="GridView_ButtonCommand">
                                            <Columns>
                                                <asp:BoundField DataField="name" ItemStyle-Width="100px"  ItemStyle-Font-Bold="true" />
                                                <asp:BoundField DataField="price" DataFormatString="{0:C}" ItemStyle-Width="80px" />
                                                <asp:ButtonField Text="ADD" ButtonType="Link" ControlStyle-CssClass="GridButton"></asp:ButtonField>
                                            </Columns>
                                        </asp:GridView>
                                    </Content>
                                </ajaxToolkit:AccordionPane>
                            </Panes>
                        </ajaxToolkit:Accordion>
                        </div>
                    </div>
                    <asp:Panel runat="server" Visible="True" CssClass="AddServicePanel">
                        <div class="PaddingPanel">
                            <div class="PanelBlock">
                                <asp:Label runat="server" Text="SELECTED SERVICE" Font-Bold="true" CssClass="LabelAddingService"></asp:Label>
                                <asp:Label runat="server" CssClass="LabelAddingService" Text="None" Font-Italic="True"></asp:Label>
                            </div>
                            <div class="PanelBlock">
                                <asp:Label runat="server" Text="CHOOSE THE DATE" Font-Bold="true" CssClass="LabelAddingService"></asp:Label>
                                <asp:TextBox Enabled="false" ID ="TextEntry" Width ="80px" Height="20px" style="text-align:center; border-radius:3px; border-width:1px; margin-right:2px;" ReadOnly="true" runat ="server" />
                                <asp:ImageButton ID="ShowEntry"  Enabled="false" Width="18px" Height="18px" ImageAlign="Middle" ImageUrl="assets/Calendar.png" BorderWidth ="1px" BackColor="White" style="border-radius:3px"  AlternateText="No Image available" runat="server" />
                                <ajaxToolkit:CalendarExtender ID="EntryCalendar" PopupButtonID="ShowEntry" runat="server"  TargetControlID="TextEntry" Format="dd/MM/yyyy" ></ajaxToolkit:CalendarExtender>
                            </div>
                            <div class="PanelBlock">
                                <asp:Label runat="server" Text="CHOOSE THE HOUR" Font-Bold="true" CssClass="HourServices"></asp:Label>
                                <asp:TextBox ID ="HourTextBox" Width ="80px" Height="20px" style="text-align:center; border-radius:3px; border-width:1px;" runat ="server" Enabled="false" />
                                <ajaxToolkit:MaskedEditExtender runat="server" CultureDatePlaceholder="" CultureTimePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureDateFormat="" CultureCurrencySymbolPlaceholder="" CultureAMPMPlaceholder="" Century="2000" BehaviorID="TextBox1_MaskedEditExtender" TargetControlID="HourTextBox" ID="HourTextBox_MaskedEditExtender" MaskType="Time" Mask="99:00" ClearMaskOnLostFocus="False" UserTimeFormat="None"></ajaxToolkit:MaskedEditExtender>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Not correct hour introduced" ControlToValidate="HourTextBox" ValidationExpression="^([0-1]?[0-9]|2[0-3]):00$" Display="Dynamic"></asp:RegularExpressionValidator>
                            </div>
                            <div class="PanelBlock">
                                <asp:Label runat="server" Text="CHOOSE YOUR STAFF" Font-Bold="true" CssClass="HourServices"></asp:Label>
                                <asp:DropDownList ID="StaffList" runat="server" Enabled="false" CssClass="ListStaff"></asp:DropDownList>
                            </div>
                            <div class="PanelBlock">
                                <asp:Button ID="AddServiceButton" CssClass="ButtonAddService" runat="server" Text="Add Service" />
                            </div>
                        </div>
                    </asp:Panel>
                    <div class="MainButtonTotalDiv">
                            <asp:Button class="MainButtonTotal" ID="Button1" runat="server" Text="Continue" OnClick="ContinueButton_Click" />
                    </div>
                </div>
            </div>

            <aside class="BookingResume">
                <div class="MainBlock">
                    <div class="HeaderBlock">
                        <h1 class="BookingSumLabel">Booking</h1>
                    </div>
                    <div class="FechasBlock">
                        <div class="DateBlock">
                            <asp:Label runat="server" Text="Entry date" class="LabelDateBlock"></asp:Label>
                            <asp:Label runat="server" Text="fecha" ID="EntryDateLabel"></asp:Label>
                        </div>
                        <div class="DateBlock">
                            <asp:Label runat="server" Text="Departure date" class="LabelDateBlock"></asp:Label>
                            <asp:Label runat="server" Text="fecha" ID="DepartureDateLabel"></asp:Label>
                        </div>
                    </div>
                    <div class="separator">
                        <hr />
                    </div>
                    
                    <asp:GridView ID="GridViewRooms" CssClass="grid" runat="server" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false" CellSpacing="8" ShowHeader="False" Width="100%" RowStyle-HorizontalAlign="Left"
                         OnRowCommand="GridView_ButtonCommand">

                        <Columns>
                            <asp:BoundField DataField="title" ItemStyle-Width="150px"  ItemStyle-Font-Bold="true" />
                            <asp:BoundField ItemStyle-Width="50px" />
                            <asp:BoundField DataField="price" DataFormatString="{0:C}" ItemStyle-Width="80px" />
                            <asp:ButtonField Text="Delete" ButtonType="Link" ControlStyle-CssClass="GridButton"></asp:ButtonField>
                        </Columns>
                    </asp:GridView>
                    <asp:GridView ID="GridViewServices" CssClass="grid" runat="server" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false" CellSpacing="8" ShowHeader="False" Width="100%" RowStyle-HorizontalAlign="Left"
                         OnRowCommand="GridView_ButtonCommand">

                        <Columns>
                            <asp:BoundField DataField="description" ItemStyle-Width="150px"  ItemStyle-Font-Bold="true" />
                            <asp:BoundField DataField="serviceDay" DataFormatString="{0:M}" ItemStyle-Font-Italic="true" ItemStyle-Width="50px" />
                            <asp:BoundField DataField="price" DataFormatString="{0:C}" ItemStyle-Width="80px" />
                            <asp:ButtonField Text="Delete" ButtonType="Link" ControlStyle-CssClass="GridButton"></asp:ButtonField>
                        </Columns>
                    </asp:GridView>
                    <asp:GridView ID="GridViewCars" CssClass="grid" runat="server" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false" CellSpacing="8" ShowHeader="False" Width="100%" RowStyle-HorizontalAlign="Left"
                         OnRowCommand="GridView_ButtonCommand">

                        <Columns>
                            <asp:BoundField DataField="brand" ItemStyle-Width="150px"  ItemStyle-Font-Bold="true" />
                            <asp:BoundField DataField="model" ItemStyle-Width="50px" ItemStyle-Font-Italic="true" />
                            <asp:BoundField DataField="price" DataFormatString="{0:C}" ItemStyle-Width="80px" />
                            <asp:ButtonField Text="Delete" ButtonType="Link" ControlStyle-CssClass="GridButton"></asp:ButtonField>
                        </Columns>
                    </asp:GridView>
                    <asp:GridView ID="GridViewPackages" CssClass="grid" runat="server" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false" CellSpacing="8" ShowHeader="False" Width="100%" RowStyle-HorizontalAlign="Left"
                         OnRowCommand="GridView_ButtonCommand">

                        <Columns>
                            <asp:BoundField DataField="name" ItemStyle-Width="150px"  ItemStyle-Font-Bold="true" />
                            <asp:BoundField ItemStyle-Width="50px" />
                            <asp:BoundField DataField="price" DataFormatString="{0:C}" ItemStyle-Width="80px" />
                            <asp:ButtonField Text="Delete" ButtonType="Link" ControlStyle-CssClass="GridButton"></asp:ButtonField>
                        </Columns>
                    </asp:GridView>
                    <div class="separator">
                        <hr />
                    </div>
                    <div class="totalBooking">
                        <div class="TotalPrice">
                            <asp:Label runat="server" Text="Total: " Width="100px" CssClass="LabelTotal"></asp:Label>
                            <asp:Panel runat="server" Width="110px"></asp:Panel>
                            <asp:Label runat="server" ID="TotalPriceLabel" CssClass="LabelTotal"></asp:Label>
                        </div>
                        <div class="ButtonTotalDiv">
                            <asp:Button class="ButtonTotal" ID="ContinueButton" runat="server" Text="Continue" OnClick="ContinueButton_Click" />
                        </div>
                    </div>
                </div>
            </aside>
        </div>
    </div>
</asp:Content>
