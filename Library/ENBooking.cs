using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Library
{
    public class ENBooking
    {
        // Attributes and properties
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }  // Esto es private
        }


        private ENUser _user;
        public ENUser user
        {
            get { return _user; }
            private set { _user = value; }
        }

        
        private IntervalDate _date; // Start and end date of the stay on the hotel
        public IntervalDate date
        {
            get { return _date; }
            private set { _date = value; }
        }

        
        private string _board; // It can have 3 types: OB (No board), HB (Half Board) and FB (Full Board)
        public string board
        {
            get { return _board; }
            private set 
            { 
                if (board == "OB" || board == "HB" || board == "FB")
                {
                    _board = value;
                }
                else
                {
                    Console.WriteLine("ERROR: incorrect type of board");
                }
            }
        }

        private ENDiscount _discount;
        public ENDiscount discount
        {
            get { return _discount; }
            private set { _discount = value; }
        }


        // Booking methods
        public ENBooking() { }

        public ENBooking(ENUser user, IntervalDate date, List<ENRoom> rooms, bool board)
        {
            // When you declare the booking you only can add the rooms you want, the extra services and the discounts will be added
            // after the booking is declared
        }

        public bool createBooking()
        {
            CADBooking booking = new CADBooking();
            return booking.createBooking(this);
        }

        public bool deleteBooking()
        {
            CADBooking booking = new CADBooking();
            return booking.deleteBooking(this);
        }

        public List<ENBooking> listAllBookings()
        {
            CADBooking booking = new CADBooking();
            return booking.listAllBookings();
        }

        public ENBooking searchBooking(ENUser user, IntervalDate interval)
        {
            CADBooking booking = new CADBooking();
            return booking.searchBooking(user, interval);
        }

        public bool updateBooking()  // Only can be updated the IntervalDate and the type of Board
        {
            CADBooking booking = new CADBooking();
            return booking.updateBooking(this);
        }

        // Rooms methods
        public DataSet getRooms()
        {
            CADBooking booking = new CADBooking();
            return booking.getRooms(this);
        }

        public bool addRoom(ENRoom room)
        {
            CADBooking booking = new CADBooking();
            return booking.addRoom(this, room);
        }

        public bool deleteRoom(ENRoom room)
        {
            CADBooking booking = new CADBooking();
            return booking.deleteRoom(this, room);
        }
        
        // Services methods
        public DataSet getServices()
        {
            CADBooking booking = new CADBooking();
            return booking.getServices(this);
        }

        public bool addService(ENService service)
        {
            CADBooking booking = new CADBooking();
            return booking.addService(this, service);
        }

        public bool cancelService(ENService service)
        {
            CADBooking booking = new CADBooking();
            return booking.cancelService(this, service);
        }

        // Packages methods
        public bool addPackage(ENPackage package)
        {
            CADBooking booking = new CADBooking();
            return booking.addPackage(this, package);
        }

        public bool cancelPackage(ENPackage package)
        {
            CADBooking booking = new CADBooking();
            return booking.cancelPackage(this, package);
        }

        public List<ENPackage> getPackages(ENPackage package)
        {
            CADBooking booking = new CADBooking();
            return booking.getPackages(this);
        }

        // Discounts
        public bool applyDiscount(ENDiscount discount)
        {
            CADBooking booking = new CADBooking();
            return booking.applyDiscount(this, discount);
        }

        public bool quitDiscount(ENDiscount discount)
        {
            CADBooking booking = new CADBooking();
            return booking.quitDiscount(this, discount);
        }

        public bool isDiscounted()
        {
            if (discount == null)
            {
                return false;
            }
            return true;
        }

        // Car leasing
        public bool addCar(ENCar car)
        {
            CADBooking booking = new CADBooking();
            return booking.addCar(this, car);
        }

        public bool deleteCar(ENCar car)
        {
            CADBooking booking = new CADBooking();
            return booking.deleteCar(this, car);
        }

        public List<ENCar> getCars()
        {
            CADBooking booking = new CADBooking();
            return booking.getCars(this);
        }

        // Auxiliary methods
        public int calculatePrice() // Returns the total cost of the booking (taking in account the possible discount code)
        {
            return 0;
        }
    }
}
