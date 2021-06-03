<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Car.aspx.cs" Inherits="JiltonWeb.Car" %>
<asp:Content ID="TitleForm" ContentPlaceHolderID="cssLink" runat="server">
        <link rel="stylesheet" href="../css/car.css?ver=<?php echo rand(153,999)?>" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class ="carfondo">


       <div class="car">

   
            <asp:GridView ID="GridView1" CssClass="car" OnRowCommand="GridView_ButtonCommand" RowStyle-HorizontalAlign="Center" Font-Underline="false" runat="server" Font-Size="15px" ForeColor="#F3E7E7" GridLines="Horizontal" AutoGenerateColumns="false" CellSpacing="40" ShowHeader="false" CellPadding="7">
                <Columns>

                    <asp:ImageField DataImageUrlField ="imgURL" ControlStyle-Height="355px" ControlStyle-Width="455px"  />
                    <asp:BoundField DataField="licenseplate"  ItemStyle-Width="90px"  />
                    <asp:BoundField DataField="brand" ItemStyle-Width="90px"  />
                    <asp:BoundField DataField="model" ItemStyle-Width="90px" />
                    <asp:BoundField DataField="description" ItemStyle-Width="400px" />

                    <asp:BoundField DataField="price" ItemStyle-Width="90px" ItemStyle-CssClass="text"  DataFormatString="{0:C}" />

                    <asp:ButtonField Text="RESERVE NOW" ItemStyle-Width="240px"  ControlStyle-CssClass="boton2" ButtonType="Button" />
                </Columns>

            </asp:GridView> 
     </div>
        
        <asp:Panel runat="server" ID="panelAdmin">
        <div class="admin">
            <div class="entradas">
                <div class = "labels">
                     <asp:Label runat="server" CssClass="letrasadmin" > LicensePlate: </asp:Label>
                     <asp:Label runat="server" CssClass="letrasadmin"> Brand: </asp:Label>
                     <asp:Label runat="server" CssClass="letrasadmin"> Model: </asp:Label>
                     <asp:Label runat="server" CssClass="letrasadmin"> Price:</asp:Label>
                     <asp:Label runat="server" CssClass="letrasadmin"> Description:</asp:Label>
                     <asp:Label runat="server" CssClass="letrasadmin"> imgURL:</asp:Label>

                </div>

                <div class = "data">
                    <asp:TextBox ID ="LicensePlateData" CssClass="textboxadmin" runat ="server" />
                    <asp:TextBox ID ="BrandData" CssClass="textboxadmin" runat ="server" />
                    <asp:TextBox ID ="ModelData" CssClass="textboxadmin" runat ="server" />
                    <asp:TextBox ID ="PriceData" CssClass="textboxadmin"  runat ="server" />
                    <asp:TextBox ID ="DescriptionData" CssClass="textboxadmin"  runat ="server" />
                    <asp:TextBox ID ="imgURL" CssClass="textboxadmin" Text="assets/mainEvents.jpg" runat ="server" />


                </div>
            </div>
             <div class="botonesadmin">
                <asp:Button  runat="server" CssClass="botonadmin" Text="CREATE NEW CAR" OnClick="CrearClick"></asp:Button>
                <asp:Button  runat="server" CssClass="botonadmin" Text="UPDATE EXISTING CAR" OnClick="UpdateClick"></asp:Button>
                <asp:Button  runat="server" CssClass="botonadmin" Text="DELETE EXISTING CAR" OnClick="DeleteClick"></asp:Button>
             </div>
              <div class="textoAdmin">
                <asp:Label ID="output" runat="server"></asp:Label><br/> 

                <p> To create a new car you MUST insert all the information, including at least a brief description, remember price must be a number. In the urlIMG the photo directory must be included, there's one by default if we dont insert none. To update an existing one, you have to put the License Plate of the one you want to edit and its new price or/and description. To delete, just put the License Plate.</p>
              </div>

        </div>

      </asp:Panel>
    </div> 


</asp:Content>


