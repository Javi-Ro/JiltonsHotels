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
        public List<ENRoom> getRooms(ENBooking booking)
        {
            return new List<ENRoom>();
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
        public List<ENService> getServices(ENBooking booking)
        {
            return new List<ENService>();
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

        public List<ENPackage> getPackages(ENBooking booking)
        {
            return new List<ENPackage>();
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

        public List<ENCar> getCars(ENBooking booking)
        {
            return new List<ENCar>();
        }
    }
}
