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
            constring = ConfigurationManager.ConnectionStrings["Database1"].ConnectionString;
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

                string cadena = "DELETE FROM servicio WHERE id = '"+ en.Id +"'";
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
            SqlConnection con = new SqlConnection(constring);
            DataSet aux = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM servicio", con);
            adapter.Fill(aux, "servicio");
            return aux;
        }

        public DataSet listAllGym()
        { //lista gym
            SqlConnection con = new SqlConnection(constring);
            DataSet aux = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM servicio WHERE type='gym' ", con);
            adapter.Fill(aux, "servicio1");
            return aux;
        }

        public DataSet listAllSpa()
        { //lista spa
            SqlConnection con = new SqlConnection(constring);
            DataSet aux = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM servicio WHERE type='spa' ", con);
            adapter.Fill(aux, "servicio2");
            return aux;
        }

        public ENService searchService(int id)
        {
            ENService aux = null;

            try
            {
                SqlConnection con = null;
                con = new SqlConnection(constring);
                con.Open();

                string cadena = "Select * FROM servicio WHERE id='"+ id +"' ";
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