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
            set { _id = value; }
        }

        public string user { get; set; }

        public IntervalDate date { get; set; }  // Start and end date of the stay on the hote

        private string _board; // It can have 3 types: OB (No board), HB (Half Board) and FB (Full Board)
        public string board
        {
            get { return _board; }
            set 
            { 
                if (value == "OB" || value == "HB" || value == "FB")
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
            set { _discount = value; }
        }

        public double Price { get; set; }

        public List<ENService> Services { get; set; }

        public List<ENCar> Cars { get; set; }

        public List<ENPackage> Packages { get; set; }

        public List<ENRoom> Rooms { get; set; }


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

        public DataSet listAllBookings()
        {
            CADBooking booking = new CADBooking();
            return booking.listAllBookings();
        }

        public DataSet searchBooking(ENUser user, IntervalDate interval)
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

        public DataSet getPackages()
        {
            CADBooking booking = new CADBooking();
            return booking.getPackages(this);
        }

        // Discounts
        public bool applyDiscount(ENDiscount discount)
        {
            CADBooking booking = new CADBooking();
            this.discount = discount;
            return booking.applyDiscount(this, discount);
        }

        public bool quitDiscount()
        {
            CADBooking booking = new CADBooking();
            return booking.quitDiscount(this);
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

        public DataSet getCars()
        {
            CADBooking booking = new CADBooking();
            return booking.getCars(this);
        }

        public DataSet getByID(string id)
        {
            CADBooking booking = new CADBooking();
            return booking.getByID(this, id);
        }

        // Auxiliary methods
        public double calculatePrice(DataTable rooms, DataTable services, DataTable packages, DataTable cars) // Returns the total cost of the booking (taking in account the possible discount code)
        {
            double total = 0;

            foreach (DataRow row in rooms.Rows)
            {
                total += Int32.Parse(row["price"].ToString());
            }

            if (services != null)
            {
                foreach (DataRow row in services.Rows)
                {
                    total += Int32.Parse(row["price"].ToString());
                }
            }

            if (packages != null)
            {
                foreach (DataRow row in packages.Rows)
                {
                    total += Int32.Parse(row["price"].ToString());
                }
            }

            if(cars != null)
            {
                foreach (DataRow row in cars.Rows)
                {
                    total += Int32.Parse(row["price"].ToString());
                }
            }

            switch (this.board)
            {
                case "HB":
                    total += 59.99;
                    break;
                case "FB":
                    total += 89.99;
                    break;
                default:
                    break;
            }
            
            if (this.discount != null)
            {
                return total * (100 - this.discount.percentage) / 100;
            }
            return total;
        }

        public static int fillId()
        {
            CADBooking booking = new CADBooking();
            return booking.fillId();
        }
    }
}
