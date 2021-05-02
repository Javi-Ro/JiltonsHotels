<%@ Page Title="" Language="C#" MasterPageFile="~/JiltonMaster.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="JiltonWeb.Staff" %>
<asp:Content ID="TitleForm" ContentPlaceHolderID="cssLink" runat="server">
            <link rel="stylesheet" href="../css/staff.css?ver=<?php echo rand(145,999)?>" />
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
    </div>



</asp:Content>