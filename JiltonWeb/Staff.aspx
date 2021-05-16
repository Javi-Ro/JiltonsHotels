<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="JiltonWeb.Staff" %>
<asp:Content ID="TitleForm" ContentPlaceHolderID="cssLink" runat="server">
            <link rel="stylesheet" href="../css/staff.css?ver=<?php echo rand(153,999)?>" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="stafffondo">

   
            <asp:GridView ID="GridView2" CssClass="staff" RowStyle-HorizontalAlign="Center" Font-Underline="false" runat="server" Font-Size="14px" ForeColor="#F3E7E7" GridLines="Horizontal" AutoGenerateColumns="false" CellSpacing="40" ShowHeader="false" CellPadding="7">
                <Columns>
                    <asp:ImageField DataImageUrlField ="imgURL" ControlStyle-Height="355px" ControlStyle-Width="425px"  />
                    <asp:BoundField DataField="name" ItemStyle-Width="160px"  />
                    <asp:BoundField DataField="description" ItemStyle-Width="600px" />
                    <asp:BoundField DataField="email"  ItemStyle-Width="210px"  />
                    <asp:BoundField DataField="type" ItemStyle-Width="110px" />

                </Columns>

            </asp:GridView> 

        <div class="admin">
            <div class="entradas">
                <div class = "labels">
                     <asp:Label runat="server" CssClass="letrasadmin" > Email: </asp:Label>
                     <asp:Label runat="server" CssClass="letrasadmin"> Name: </asp:Label>
                     <asp:Label runat="server" CssClass="letrasadmin"> Type: </asp:Label>
                     <asp:Label runat="server" CssClass="letrasadmin"> Description:</asp:Label>
                     <asp:Label runat="server" CssClass="letrasadmin"> imgURL:</asp:Label>

                </div>

                <div class = "data">
                    <asp:TextBox ID ="EmailData" CssClass="textboxadmin" runat ="server" />
                    <asp:TextBox ID ="NameData" CssClass="textboxadmin" runat ="server" />

                    <asp:DropDownList ID="TypeData" CssClass="textboxadmin" runat="server">

                      <asp:ListItem Value="teacher"> Teacher </asp:ListItem>
                      <asp:ListItem Value="trainer"> Trainer </asp:ListItem>
                      <asp:ListItem Value="massagist"> Massagist </asp:ListItem>
                      <asp:ListItem Value="guide"> Tourist Guide </asp:ListItem>
                    </asp:DropDownList>

                    <asp:TextBox ID ="DescriptionData" CssClass="textboxadmin"  runat ="server" />
                    <asp:TextBox ID ="imgURL" CssClass="textboxadmin" Text="assets/defaultStaff.jpg" runat ="server" />

                </div>
            </div>
             <div class="botonesadmin">
                <asp:Button  runat="server" CssClass="botonadmin" Text="CREATE NEW STAFF" OnClick="CrearClick"></asp:Button>
                <asp:Button  runat="server" CssClass="botonadmin" Text="UPDATE EXISTING STAFF" OnClick="UpdateClick"></asp:Button>
                <asp:Button  runat="server" CssClass="botonadmin" Text="DELETE EXISTING STAFF" OnClick="DeleteClick"></asp:Button>
             </div>
              <div class="texto">
                <asp:Label ID="output" runat="server"></asp:Label><br/> 
                  <br>
                <p> To create a new staff member you MUST insert all the information, you have to also include, at least, a brief description. To update an existing member, you have to put the email of it, and its new description. In order to delete a member, introduce its contact direction.
                    IT'S IMPORTANT TO NOT INTRODUCE SIMPLE QUOTES AS IT WILL FAIL THEN!
                </p>
              </div>


        </div>


    </div>



</asp:Content>