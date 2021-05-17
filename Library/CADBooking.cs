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
            return true;
        }

        public bool deleteBooking(ENBooking booking)
        {
            return true;
        }

        public List<ENBooking> listAllBookings()
        {
            return new List<ENBooking>();
        }

        public ENBooking searchBooking(ENUser user, IntervalDate interval)
        {
            return new ENBooking();
        }

        public bool updateBooking(ENBooking booking)
        {
            return true;
        }

        // Methods for rooms
        public DataSet getRooms(ENBooking booking)
        {
            SqlConnection c = new SqlConnection(constring);
            DataSet virtualSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select title,price,type from room where bookingNumber=" + booking.ID, c);
            adapter.Fill(virtualSet, "booking");
            return virtualSet;
        }

        public bool addRoom(ENBooking booking, ENRoom room)
        {
            return true;
        }

        public bool deleteRoom(ENBooking booking, ENRoom room)
        {
            return true;
        }

        // Methods for services
        public DataSet getServices(ENBooking booking)
        {
            SqlConnection c = new SqlConnection(constring);
            DataSet virtualSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select description,price,serviceDay from servicio s, bookService bs where s.id=bs.serviceID and bookingID=" + booking.ID, c);
            adapter.Fill(virtualSet, "booking");
            return virtualSet;
        }

        public bool addService(ENBooking booking, ENService service)
        {
            return true;
        }

        public bool cancelService(ENBooking booking, ENService service)
        {
            return true;
        }

        // Methods for packages
        public bool addPackage(ENBooking booking, ENPackage package)
        {
            return true;
        }

        public bool cancelPackage(ENBooking booking, ENPackage package)
        {
            return true;
        }

        public DataSet getPackages(ENBooking booking)
        {
            SqlConnection c = new SqlConnection(constring);
            DataSet virtualSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select name, price from package p, bookPackage bp where bp.idPackage=p.id and idBooking=" + booking.ID, c);
            adapter.Fill(virtualSet, "booking");
            return virtualSet;
        }

        // Methods for discounts
        public bool applyDiscount(ENBooking booking, ENDiscount discount)
        {
            return true;
        }

        public bool quitDiscount(ENBooking booking, ENDiscount discount)
        {
            return true;
        }

        // Car leasing
        public bool addCar(ENBooking booking, ENCar car)
        {
            return true;
        }

        public bool deleteCar(ENBooking booking, ENCar car)
        {
            return true;
        }

        public DataSet getCars(ENBooking booking)
        {
            SqlConnection c = new SqlConnection(constring);
            DataSet virtualSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select brand, model, price from car where bookingNumber=" + booking.ID, c);
            adapter.Fill(virtualSet, "booking");
            return virtualSet;
        }
    }
}
