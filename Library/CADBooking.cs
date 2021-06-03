using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using System.Globalization;

namespace Library
{
    public class CADBooking
    {
        private string constring;

        public CADBooking()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        // Methods for bookings (CRUD operations)
        public bool createBooking(ENBooking booking)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from booking", c);
                adapter.Fill(virtualSet, "booking");
                DataTable t = new DataTable();
                t = virtualSet.Tables["booking"];
                DataRow dr = t.NewRow();
                dr[0] = booking.ID; dr[1] = booking.board; dr[2] = DateTime.ParseExact(booking.date.startDate.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture); 
                dr[3] = DateTime.ParseExact(booking.date.endDate.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture); dr[4] = booking.user; dr[5] = booking.discount;
                t.Rows.Add(dr);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(virtualSet, "booking");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Booking creation had failed.Error: {0}", e.Message);
                return false;
            }
        }

        public bool deleteBooking(ENBooking booking)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from booking", c);
                adapter.Fill(virtualSet, "booking");
                DataTable t = new DataTable();
                t = virtualSet.Tables["booking"];
                foreach (DataRow dr in t.Rows)
                {
                    if (dr[0].ToString() == booking.ID.ToString())
                    {
                        t.Rows.Remove(dr);
                    }
                }
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(virtualSet, "booking");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Booking remove had failed.Error: {0}", e.Message);
                return false;
            }
        }

        public DataSet listAllBookings()
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from booking", c);
                adapter.Fill(virtualSet, "booking");
                return virtualSet;
            }
            catch (Exception e)
            {
                Console.WriteLine("Booking listing had failed.Error: {0}", e.Message);
                return null;
            }
        }

        public DataSet searchBooking(ENUser user, IntervalDate interval)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from booking where userID='" + user.ID + "' and date_in='" + interval.startDate.day
                    + "/" + interval.startDate.month + "/" + interval.startDate.year + "' and date_out='" + interval.endDate.day
                    + "/" + interval.endDate.month + "/" + interval.endDate.year + "'", c);
                adapter.Fill(virtualSet, "booking");
                return virtualSet;
            }
            catch (Exception e)
            {
                Console.WriteLine("Booking search had failed.Error: {0}", e.Message);
                return null;
            }
        }

        public bool updateBooking(ENBooking booking)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from booking where id = " + booking.ID, c);
                adapter.Fill(virtualSet, "booking");
                DataTable t = new DataTable();
                t = virtualSet.Tables["booking"];
                t.Rows[0][1] = booking.board; t.Rows[0][2] = booking.date.startDate; t.Rows[0][3] = booking.date.endDate;
                t.Rows[0][4] = booking.user; t.Rows[0][5] = booking.discount;
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(virtualSet, "booking");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Booking update had failed.Error: {0}", e.Message);
                return false;
            }
        }

        // Methods for rooms
        public DataSet getRooms(ENBooking booking)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select title,price,type from room where bookingNumber=" + booking.ID, c);
                adapter.Fill(virtualSet, "booking");
                return virtualSet;
            }
            catch (Exception e)
            {
                Console.WriteLine("Rooms listing had failed.Error: {0}", e.Message);
                return null;
            }
        }

        public bool addRoom(ENBooking booking, ENRoom room)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from room where id = " + room.id, c);
                adapter.Fill(virtualSet, "booking");
                DataTable t = new DataTable();
                t = virtualSet.Tables["booking"];
                t.Rows[0][5] = booking.ID;
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(virtualSet, "booking");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Rooms adding had failed.Error: {0}", e.Message);
                return false;
            }
        }

        public bool deleteRoom(ENBooking booking, ENRoom room)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from room where id = " + room.id, c);
                adapter.Fill(virtualSet, "booking");
                DataTable t = new DataTable();
                t = virtualSet.Tables["booking"];
                t.Rows[0][5] = null;
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(virtualSet, "booking");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Rooms deleting had failed.Error: {0}", e.Message);
                return false;
            }
        }

        // Methods for services
        public DataSet getServices(ENBooking booking)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select description,price,serviceDay from servicio s, bookService bs where s.id=bs.serviceID and bookingID=" + booking.ID, c);
                adapter.Fill(virtualSet, "booking");
                return virtualSet;
            }
            catch (Exception e)
            {
                Console.WriteLine("Services listing had failed.Error: {0}", e.Message);
                return null;
            }
        }

        public bool addService(ENBooking booking, ENService service)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from bookService", c);
                adapter.Fill(virtualSet, "booking");
                DataTable t = new DataTable();
                t = virtualSet.Tables["booking"];
                DataRow dr = t.NewRow();
                dr[0] = booking.ID; dr[1] = service.Id;
                t.Rows.Add(dr);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(virtualSet, "booking");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Rooms adding had failed.Error: {0}", e.Message);
                return false;
            }
        }

        public bool cancelService(ENBooking booking, ENService service)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from bookService where serviceId = " + service.Id + "and bookingId = " + booking.ID, c);
                adapter.Fill(virtualSet, "booking");
                DataTable t = new DataTable();
                t = virtualSet.Tables["booking"];
                t.Rows.Remove(t.Rows[0]);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(virtualSet, "booking");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Rooms adding had failed.Error: {0}", e.Message);
                return false;
            }
        }

        // Methods for packages
        public bool addPackage(ENBooking booking, ENPackage package)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from bookPackage", c);
                adapter.Fill(virtualSet, "booking");
                DataTable t = new DataTable();
                t = virtualSet.Tables["booking"];
                DataRow dr = t.NewRow();
                dr[0] = booking.ID; dr[1] = package.id;
                t.Rows.Add(dr);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(virtualSet, "booking");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Package adding had failed.Error: {0}", e.Message);
                return false;
            }
        }

        public bool cancelPackage(ENBooking booking, ENPackage package)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from bookPackage where serviceId = " + package.id + "and bookingId = " + booking.ID, c);
                adapter.Fill(virtualSet, "booking");
                DataTable t = new DataTable();
                t = virtualSet.Tables["booking"];
                t.Rows.Remove(t.Rows[0]);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(virtualSet, "booking");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Package cancelling had failed.Error: {0}", e.Message);
                return false;
            }
        }

        public DataSet getPackages(ENBooking booking)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select name, price from package p, bookPackage bp where bp.idPackage=p.id and idBooking=" + booking.ID, c);
                adapter.Fill(virtualSet, "booking");
                return virtualSet;
            }
            catch (Exception e)
            {
                Console.WriteLine("Packages listing had failed.Error: {0}", e.Message);
                return null;
            }
        }

        // Methods for discounts
        public bool applyDiscount(ENBooking booking, ENDiscount discount)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from booking where id = " + booking.ID, c);
                adapter.Fill(virtualSet, "booking");
                DataTable t = new DataTable();
                t = virtualSet.Tables["booking"];
                t.Rows[0][5] = booking.discount;
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(virtualSet, "booking");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Discount adding had failed.Error: {0}", e.Message);
                return false;
            }
        }

        public bool quitDiscount(ENBooking booking)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from booking where id = " + booking.ID, c);
                adapter.Fill(virtualSet, "booking");
                DataTable t = new DataTable();
                t = virtualSet.Tables["booking"];
                t.Rows[0][5] = null;
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(virtualSet, "booking");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Discount removing had failed.Error: {0}", e.Message);
                return false;
            }
        }

        // Car leasing
        public bool addCar(ENBooking booking, ENCar car)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from car where licensePlate = " + car.LicensePlate, c);
                adapter.Fill(virtualSet, "booking");
                DataTable t = new DataTable();
                t = virtualSet.Tables["booking"];
                t.Rows[0][5] = booking.ID;
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(virtualSet, "booking");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Car adding had failed.Error: {0}", e.Message);
                return false;
            }
        }

        public bool deleteCar(ENBooking booking, ENCar car)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from car where licensePlate = " + car.LicensePlate, c);
                adapter.Fill(virtualSet, "booking");
                DataTable t = new DataTable();
                t = virtualSet.Tables["booking"];
                t.Rows[0][5] = null;
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(virtualSet, "booking");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Rooms deleting had failed.Error: {0}", e.Message);
                return false;
            }
        }

        public DataSet getCars(ENBooking booking)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select brand, model, price from car where bookingNumber=" + booking.ID, c);
                adapter.Fill(virtualSet, "booking");
                return virtualSet;
            }
            catch (Exception e)
            {
                Console.WriteLine("Cars listing had failed.Error: {0}", e.Message);
                return null;
            }
        }

        // Auxiliary methods
        public int fillId()
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                DataSet virtualSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select max(id) from booking", c);
                adapter.Fill(virtualSet, "id");
                DataTable t = new DataTable();
                t = virtualSet.Tables["id"];
                return (int)t.Rows[0][0] + 1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Id filling had failed.Error: {0}", e.Message);
                return -1;
            }
        }
    }
}
