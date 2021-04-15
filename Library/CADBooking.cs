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

        // Methods for bookings
        public bool createBooking(ENBooking booking)
        {

        }

        public bool deleteBooking(ENBooking booking)
        {

        }

        public bool searchBooking(ENBooking booking)  // Looks for a booking on the db with the same user and date that the caller
        {

        }

        // Methods for rooms
        const public ENRoom[] getRooms(ENBooking booking)
        {

        }

        public bool addRoom(ENBooking booking, ENRoom room)
        {

        }

        public bool deleteRoom(ENBooking booking, ENRoom room)
        {

        }

        // Methods for services
        const public ENService[] getServices(ENBooking booking)
        {

        }

        public bool addService(ENBooking booking, ENService service)
        {

        }

        public bool cancelService(ENBooking booking, ENService service)
        {

        }

        // Methods for packages
        public bool addPackage(ENBooking booking, ENPackage package)
        {

        }

        public bool cancelPackage(ENBooking booking, ENPackage package)
        {

        }

        // Methods for discounts
        public bool applyDiscount(ENBooking booking, ENDiscount discount)
        {

        }

        public bool quitDiscount(ENBooking booking, ENDiscount discount)
        {

        }
    }
}
