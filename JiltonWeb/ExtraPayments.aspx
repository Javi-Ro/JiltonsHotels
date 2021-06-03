<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="ExtraPayments.aspx.cs" Inherits="JiltonWeb.ExtraPayments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cssLink" runat="server">
    <link rel="stylesheet" href="../css/ExtraPayments.css?ver=<?php echo rand(295,950)?>" />
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
                    <asp:Image runat="server" CssClass="cardImg" ID="VisaCard" src="../assets/VisaCard.png"/>
                    <asp:Image runat="server" CssClass="cardImg" ID="MasterCard" src="../assets/MasterCard.png"/>
                    <asp:Image runat="server" CssClass="cardImg" ID="AmexCard" src="../assets/AmexCard.png"/>
                </div>
                <div class="PaymentForm">
                    <div class="Block">
                        <asp:TextBox id="CardNumber" CssClass="PaymentTextBox" placeholder="Card Number*" runat="server" MaxLength="16"  AutoPostBack="True"></asp:TextBox>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="CardNumber" EventName="TextChanged" />
                            </Triggers>
                        </asp:UpdatePanel>
                        <ajaxToolkit:MaskedEditExtender ID="CardNumber_MaskedEditExtender" runat="server" BehaviorID="CardNumber_MaskedEditExtender" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Mask='9999 9999 9999 9999' TargetControlID="CardNumber" MaskType="Number" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorCardNumber" CssClass="Validator" runat="server" ErrorMessage="Card number is required" ControlToValidate="CardNumber" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorCardVisa" CssClass="Validator" runat="server" ErrorMessage="Invalid Card Number" ValidationExpression="^(?:4[0-9]{12}(?:[0-9]{3})?|(?:5[1-5][0-9]{2}|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[01][0-9]|2720)[0-9]{12}|3[47][0-9]{13})$" ControlToValidate="CardNumber" Display="Dynamic"></asp:RegularExpressionValidator>
                        
                    </div>
                    <div class="Block">
                        <asp:TextBox id="ExpirationDate" CssClass="PaymentTextBox" placeholder="Expiration Date* (mm/yyyy)" runat="server" AutoPostBack="True"></asp:TextBox>
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="ExpirationDate" EventName="TextChanged" />
                            </Triggers>
                        </asp:UpdatePanel>
                        <ajaxToolkit:MaskedEditExtender runat="server" CultureDatePlaceholder="" CultureTimePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureDateFormat="" CultureCurrencySymbolPlaceholder="" CultureAMPMPlaceholder="" Century="2000" BehaviorID="ExpirationDate_MaskedEditExtender" TargetControlID="ExpirationDate" ID="ExpirationDate_MaskedEditExtender" Mask="99\/9999" MaskType="Date"></ajaxToolkit:MaskedEditExtender>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorDate" CssClass="Validator" runat="server" ErrorMessage="Invalid Expiration date" ValidationExpression="\d{2}/\d{4}" ControlToValidate="ExpirationDate" Display="Dynamic"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorDate" CssClass="Validator" runat="server" ErrorMessage="Expiration date is required" ControlToValidate="ExpirationDate" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                    <div class="Block">
                        <asp:TextBox id="CVV" CssClass="PaymentTextBox" placeholder="CVV*" runat="server" MaxLength="3" Type="password" ></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorCVV" CssClass="Validator" runat="server" ErrorMessage="Invalid CVV code" ValidationExpression="\d{3}" ControlToValidate="CVV" Display="Dynamic"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorCVV" CssClass="Validator" runat="server" ErrorMessage="CVV is required" ControlToValidate="CVV"></asp:RequiredFieldValidator>
                    </div>
                    <div class="Block">
                        <asp:TextBox id="TitularName" CssClass="PaymentTextBox" placeholder="Titular Name*" runat="server"></asp:TextBox>
                        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="TitularName" EventName="TextChanged" />
                            </Triggers>
                        </asp:UpdatePanel>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorTitularName" CssClass="Validator" runat="server" ErrorMessage="Titular name is required" ControlToValidate="TitularName"></asp:RequiredFieldValidator>
                    </div>
                    
                </div>
                <asp:Button runat="server" CssClass="PaymentButton" ID="PayNowButton" Text="PAY NOW" />
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
                    <div class="TotalPrice">
                        <asp:Label runat="server" Text="Total: " Width="100px" CssClass="LabelTotal"></asp:Label>
                        <asp:Panel runat="server" Width="110px"></asp:Panel>
                        <asp:Label runat="server" ID="TotalPriceLabel" CssClass="LabelTotal"></asp:Label>
                    </div>
                </div>
            </aside>
        </div>
    </div>
</asp:Content>
