<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="JiltonWeb.Staff" %>
<asp:Content ID="TitleForm" ContentPlaceHolderID="cssLink" runat="server">
            <link rel="stylesheet" href="../css/staff.css?ver=<?php echo rand(153,999)?>" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="stafffondo">
    <div class="staff">

        <div class="foto">
            <img src="assets/teacher.jpg" width="475" height="325"/>
        </div>

        <div class ="texto">
            <h1> Teacher </h1>

            <p> This is David Calle. He's one of the most popular world-wide reconiced,
                he used to teach on platforms suchs as YouTube. Recently he said "I'm so glad being able to join Jilton Hotels, I always
                wanted to work in the most important Hotel in the country. I will do everything I can in order to teach your childs!"
            </p>
            <br /> <br />

            <p> For more information about classes contact teachers@jilton.com </p>

        </div>
        
    </div>

    <div class="staff">

        <div class="foto">
            <img src="assets/trainer.jpg" width="475" height="325"/>
        </div>

        <div class ="texto">
            <h1> Trainer </h1>

            <p> This is Cristiano Ronaldo, also known as "El Bicho", "CR7" and "Mi comandante". After a long carrer at Lisboa, London, Madrid and Turín, 
                he wanted to leave football to keep improving his physical knowledge. After 6 years of studying at University of Massachusetts,
                Cristiano Ronaldo was recluited by Jilton Hotel.
            </p>
            <br /> <br />

            <p> For training sesions and information contact trainer@jilton.com </p>

        </div>
        
    </div>

    <div class="staff">

        <div class="foto">
            <img src="assets/massagist.jpg" width="475" height="325"/>
        </div>

        <div class ="texto">
            <h1> Massagist </h1>

            <p> This is Leo Messi. After winning almost everything in his football carrer, he started a superior cycle
                about administration and company management. Finally ended with a degree on massage therapist. When he joined
                Jilton Staff he affirmed: "Eventhough I'm the best player ever on football history, I want to keep developing myself
                in other topics, and being part of Jilton Staff is always a pleasure".

            </p>
            <br /> <br />

            <p> For the massagist timetable contact massagist@jilton.com </p>

        </div>
        
    </div>

    <div class="staff">

        <div class="foto">
            <img src="assets/guide.jpg" width="475" height="325"/>
        </div>

        <div class ="texto">
            <h1> Tourist Guide </h1>

            <p> This is Ester Exposito. In the last years she became the most famous Spanish women among social networks after filming
                many popular Netflix Series such as Elite. Once she reached the peak of her carrer, in an interview on La Resistencia she
                said that when she was a child always wanted to became a tourist guide in Jilton Hotel. We are proud of announcing her as 
                the official guide!
            </p>
            <br /> <br />

            <p> For more information about expeditions contact guide@jilton.com </p>

        </div>
        
    </div>

        <div class="admin">
            <div class="entradas">
                <div class = "labels">
                     <asp:Label runat="server" CssClass="letrasadmin" > Email: </asp:Label>
                     <asp:Label runat="server" CssClass="letrasadmin"> Name: </asp:Label>
                     <asp:Label runat="server" CssClass="letrasadmin"> Type: </asp:Label>
                     <asp:Label runat="server" CssClass="letrasadmin"> Description:</asp:Label>

                </div>

                <div class = "data">
                    <asp:TextBox ID ="EmailData" CssClass="textboxadmin" runat ="server" />
                    <asp:TextBox ID ="NameData" CssClass="textboxadmin" runat ="server" />

                    <asp:DropDownList ID="TypeList" CssClass="textboxadmin" runat="server">
                      <asp:ListItem Value="Teacher"> Teacher </asp:ListItem>
                      <asp:ListItem Value="Trainer"> Trainer </asp:ListItem>
                      <asp:ListItem Value="Massagist"> Massagist </asp:ListItem>
                      <asp:ListItem Value="Tourist Guide"> Tourist Guide </asp:ListItem>
                    </asp:DropDownList>

                    <asp:TextBox ID ="DescriptionData" CssClass="textboxadmin"  runat ="server" />


                </div>
            </div>
             <div class="botonesadmin">
                <asp:Button  runat="server" CssClass="botonadmin" Text="CREATE NEW STAFF" OnClick="CrearClick"></asp:Button>
                <asp:Button  runat="server" CssClass="botonadmin" Text="UPDATE EXISTING STAFF" OnClick="UpdateClick"></asp:Button>
                <asp:Button  runat="server" CssClass="botonadmin" Text="DELETE EXISTING STAFF" OnClick="DeleteClick"></asp:Button>
             </div>
              <div class="texto">
                <asp:Label ID="output" runat="server"></asp:Label><br/> 

                <p> To create a new staff member you MUST insert all the information, you have to also include, at least, a brief description. To update an existing member, you have to put the email of it, and its new description. In order to delete a member, introduce its contact direction.</p>
              </div>


        </div>


    </div>



</asp:Content>