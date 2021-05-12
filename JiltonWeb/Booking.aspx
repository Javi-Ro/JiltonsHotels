<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="JiltonWeb.Booking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cssLink" runat="server">
        <link rel="stylesheet" href="../css/booking.css?ver=<?php echo rand(255,950)?>" />
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
                        <ajaxToolkit:MaskedEditExtender ID="CardNumber_MaskedEditExtender" runat="server" BehaviorID="CardNumber_MaskedEditExtender" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Mask='9999-9999-9999-9999' TargetControlID="CardNumber" MaskType="Number" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorCardNumber" CssClass="Validator" runat="server" ErrorMessage="Card number is required" ControlToValidate="CardNumber" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorCardVisa" CssClass="Validator" runat="server" ErrorMessage="Invalid Card Number" ValidationExpression="^(?:4[0-9]{12}(?:[0-9]{3})?|(?:5[1-5][0-9]{2}|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[01][0-9]|2720)[0-9]{12}|3[47][0-9]{13})$" ControlToValidate="CardNumber" Display="Dynamic"></asp:RegularExpressionValidator>
                        
                    </div>
                    <div class="Block">
                        <asp:TextBox id="ExpirationDate" CssClass="PaymentTextBox" placeholder="Expiration Date* (mm/yyyy)" runat="server" MaxLength="6"></asp:TextBox>
                        <ajaxToolkit:MaskedEditExtender runat="server" CultureDatePlaceholder="" CultureTimePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureDateFormat="" CultureCurrencySymbolPlaceholder="" CultureAMPMPlaceholder="" Century="2000" BehaviorID="ExpirationDate_MaskedEditExtender" TargetControlID="ExpirationDate" ID="ExpirationDate_MaskedEditExtender" Mask="99/9999" MaskType="Date"></ajaxToolkit:MaskedEditExtender>
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
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorTitularName" CssClass="Validator" runat="server" ErrorMessage="Titular name is required" ControlToValidate="TitularName"></asp:RequiredFieldValidator>
                    </div>
                    
                </div>
                <asp:Button runat="server" CssClass="PaymentButton" Text="PAY NOW" />
            </div>
            </div>
            <aside class="BookingResume">
                <div class="MainBlock">
                <div class="HeaderBlock">
                    <h1 class="BookingSumLabel">Booking</h1>
                </div>
                <div class="ListViewSeparator">
                <asp:ListView ID="ListViewBooking" runat="server" DataSourceID="SqlDataSourceDefault" DataKeyNames="id" >
                    <EmptyDataTemplate>
                        <span>No se han devuelto datos.</span>
                    </EmptyDataTemplate>
                    <AlternatingItemTemplate>
                        <span style="display:flex; flex-flow:row;">
                            <span style="width:60%;">
                                <div>
                                    Id:
                                    <asp:Label Text='<%# Eval("id") %>' runat="server" ID="idLabel" /><br />
                                    Nombre:
                                    <asp:Label Text='<%# Eval("nombre") %>' runat="server" ID="nombreLabel" /><br />
                                    Nif:
                                    <asp:Label Text='<%# Eval("nif") %>' runat="server" ID="nifLabel" /><br />
                                    Edad:
                                    <asp:Label Text='<%# Eval("edad") %>' runat="server" ID="edadLabel" />
                                </div>
                            </span>
                            <span style="display:flex; width:40%; justify-content:flex-end; align-items:center;">
                                <div>
                                    <asp:Button runat="server" Text="Eliminar" Height="30px"/>
                                </div>
                            </span>
                            
                        </span>
                        <br />
                    </AlternatingItemTemplate>
                    <EditItemTemplate>
                        <span style="margin-left: 10px; font-size: 20px;">id:
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
                        <span style="">Id:
                            <asp:Label Text='<%# Eval("id") %>' runat="server" ID="idLabel" /><br />
                            Nombre:
                            <asp:Label Text='<%# Eval("nombre") %>' runat="server" ID="nombreLabel" /><br />
                            Nif:
                            <asp:Label Text='<%# Eval("nif") %>' runat="server" ID="nifLabel" /><br />
                            Edad:
                            <asp:Label Text='<%# Eval("edad") %>' runat="server" ID="edadLabel" /><br />
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
                </div>
                    <asp:SqlDataSource ID="SqlDataSourceDefault" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBPrueba.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Usuarios]"></asp:SqlDataSource>
                </div>
            </aside>
        </div>
    </div>
</asp:Content>
