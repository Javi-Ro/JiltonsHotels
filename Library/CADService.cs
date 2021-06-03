using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;

namespace Library
{
    public class CADService
    {
        private string constring;

        public CADService()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        }

        public bool createService(ENService en)
        {
            bool ok = false;
            try
            {
                SqlConnection con = null;
                con = new SqlConnection(constring);
                con.Open();

                string cadena;
                cadena = "Insert INTO servicio (id, description, price, name, maxPeople, imgURL, type) VALUES ('" + en.Id +"', '" + en.Descritpion + "', '"+ en.Price +"', '"+ en.Name +"', '"+ en.MaxPeople +"', '"+ en.ImgURL +"' ,'"+ en.Type +"')";
                SqlCommand com = new SqlCommand(cadena, con);
                com.ExecuteNonQuery();
                ok = true;
            }
            catch(SqlException e)
            {
                ok = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch(Exception e)
            {
                ok = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }

            return ok;
        }

        public bool deleteService(ENService en)
        {
            bool ok = true;
            try
            {
                SqlConnection con = null;
                con = new SqlConnection(constring);
                con.Open();

                string cadena = "DELETE * FROM servicio WHERE id = '"+ en.Id +"'";
                SqlCommand com = new SqlCommand(cadena, con);
                com.ExecuteNonQuery();
                ok = true;
                con.Close();
            }
            catch(SqlException e) 
            {
                ok = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch(Exception e)
            {
                ok = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }

            return ok;
        }

        public bool updateService(ENService en)
        {
            bool ok = true;
            try
            {
                SqlConnection con = null;
                con = new SqlConnection(constring);
                con.Open();

                string cadena = "UPDATE servicio SET id='"+ en.Id +"', description='"+ en.Descritpion +"', price='"+ en.Price +"', name='"+ en.Name +"', maxPeople='"+ en.MaxPeople +"', imgURL='"+ en.ImgURL +"', type='"+ en.Type +"' WHERE id='"+ en.Id +"'   ";
                SqlCommand com = new SqlCommand(cadena, con);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e)
            {
                ok = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                ok = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }

            return ok;
        }

        public DataSet listAllServices()
        { //lista todo
            DataSet aux = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM servicio", con);
                adapter.Fill(aux, "servicio");
                return aux;
            }
            catch (SqlException e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }

            return aux;
        }

        public DataSet listMoreServices()
        { //lista todo
            DataSet aux = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT description,price FROM servicio where type!='spa' and type!='gym'", con);
                adapter.Fill(aux, "servicio");
                return aux;
            }
            catch (SqlException e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }

            return aux;
        }

        public DataSet listAllGym()
        { //lista gym
            DataSet aux = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, description, price, imgURL FROM servicio WHERE type='gym' ", con);
                adapter.Fill(aux, "servicio1");
                return aux;
            }
            catch (SqlException e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }

            return aux;
        }

        public DataSet listAllSpa()
        { //lista spa
            DataSet aux = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, description, price, imgURL FROM servicio WHERE type='spa' ", con);
                adapter.Fill(aux, "servicio2");
                return aux;
            }
            catch (SqlException e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }

            return aux;
        }

        public ENService searchService(string description)
        {
            ENService aux = null;

            try
            {
                SqlConnection con = null;
                con = new SqlConnection(constring);
                con.Open();

                string cadena = "Select * FROM servicio WHERE description='"+ description +"' ";
                SqlCommand com = new SqlCommand(cadena, con);
                SqlDataReader datos = com.ExecuteReader();
                datos.Read();

                aux.Id = int.Parse(datos["id"].ToString());
                aux.Descritpion = datos["description"].ToString();
                aux.Price = int.Parse(datos["price"].ToString());
                aux.Name = datos["name"].ToString();
                aux.MaxPeople = int.Parse(datos["maxPeople"].ToString());
                aux.ImgURL = datos["imgURL"].ToString();
                aux.Type = datos["Type"].ToString();

                datos.Close();
                con.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }

            return aux;
        }

    }
}

/*<div class="spatitulo">
                    <asp:Label runat="server" align="center" CssClass="infospa1" >Here you will find information about our Spa & Gym services and reservations</asp:Label>
                </div>
        
                <div class="fotopiscispa">
                    <asp:Image runat="server" src ="assets/spapiscina.jpg" class ="PiscinaSpa"/>
                </div>
                <br />

                <div class="piscina1">
                    <asp:Label runat="server" CssClass="infospa">The relaxing spa's pool - With 50 meters long you will enjoy a quite relaxing experience</asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="ReserSpaPool" runat="server" Text="RESERVE" CssClass="reserva" />
                </div> 
                <br />
                <br />

                <div class="fotojac">
                    <asp:Image runat="server" src ="assets/jacuzzispa.jpg" class="JacSpa"/>
                </div>
                <br />

                <div class="jacuzzi">
                    <asp:Label runat="server"  CssClass="infospa3">Jacuzzi - With 100 water modes desingned for a comfort time </asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="ReserSpaJac" runat="server" Text="RESERVE" CssClass="reserva"/>
                </div> 
                <br />

                <div class="fotomasaje">
                    <asp:Image runat="server" src="assets/masspa.jpg" class="SpaMas"/> 
                </div>
                <br />

                <div class="masajes">
                    <asp:Label runat="server" CssClass="infospa2">Massages - You make your massage´s choice between more than a hundred, and then just relax</asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="ReserSpaMas" runat="server" Text="RESERVE" CssClass="reserva"/>
                </div>
                <br />

                <div class="fototrat">
                    <asp:Image runat="server" src="assets/masajes.png" class="TratSpa"/>
                </div>
                <br />

                <div class="tratamientos"> 
                    <br />
                    <asp:Label runat="server" CssClass="infospa4">Anti-stress treatments - Treatments for the people who really need to disconect from the world</asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="ReserSpaTrat" runat="server" Text="RESERVE" CssClass="reserva"/>
                </div>
                <br />*/

/*<div class="gym1">
                <asp:Label runat="server" CssClass="infospa5">The gym section where you will find one of the best gymnasiums of the city</asp:Label>
                <br />
            </div>
            <br />

            <div class="fotopsicigym">
                <asp:Image runat="server" src="assets/gympool.jpg" class="GymPool"/>
            </div>
            <br />

            <div class="piscina2">
                <asp:Label runat="server" CssClass="infospa6">Olympic pool - The olympic pool with one of the best quality certificates</asp:Label>
                <br />
                <br />
                <asp:Button ID="ReserGymPool" runat="server" Text="RESERVE" CssClass="reserva"/>
            </div>
            <br />

            <div class="fotomaquinas">
                <asp:Image runat="server" src="assets/gimnasiopesas.jpg" class="GymPesas"/>
            </div>
            <br />

            <div class="maquinas">
                <asp:Label runat="server" CssClass="infospa7">Gymnasium - Machines and staff will make you so easy to get in shape</asp:Label>
                <br />
                <br />
                <asp:Button ID="ReserGymMaq" runat="server" Text="RESERVE" CssClass="reserva"/>
            </div>*/