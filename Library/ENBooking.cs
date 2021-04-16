using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENBooking
    {
        // Attributes and properties
        private int _id;
        public int ID
        {
            get { return _id; }
            private set { _id = value; }
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
            set { _board = value; }  // Here will be the call to the CADBooking method, and will be controlled that the type of board is a correct type
        }

        private ENDiscount _discount;
        public ENDiscount discount
        {
            get { return _discount; }
            private set { _discount = value; }
        }


        // Booking methods
        public Booking(ENUser user, IntervalDate date, ENRoom rooms[], bool board, ENDiscount discount)
        {
            // When you create the booking you only can add the rooms you want, the extra services will be added
            // after the booking is created
        }

        public bool createBooking()
        {

        }

        public bool deleteBooking()
        {

        }

        public bool searchBooking()  // Looks for a booking on the db with the same user and date that the caller
        {

        }

        // Rooms methods
        const public ENRoom[] getRooms()
        {
            // Returs the rooms associated with the booking
        }

        public bool addRoom(ENRoom room)
        {

        }

        public bool deleteRoom(ENRoom room)
        {

        }
        
        // Services methods
        public ENService[] getServices()
        {
            // Returns the services associated with the booking
        }

        public bool addService(ENService service)
        {

        }

        public bool cancelService(ENService service)
        {

        }

        // Packages methods
        public bool addPackage(ENPackage package)
        {

        }

        public bool cancelPackage(ENPackage package)
        {

        }

        public ENPackage[] getPackages(ENPackage package)
        {
            // Returns the packages associated with a booking
        }

        // Discounts
        public bool applyDiscount(ENDiscount discount)
        {

        }

        public bool quitDiscount(ENDiscount discount)
        {

        }

        public bool isDiscounted()
        {

        }

        // Car leasing
        public bool addCar(ENCar car)
        {

        }

        public bool deleteCar(ENDiscount discount)
        {

        }

        public ENCar[] getCars()
        {
            // Returns the car leasings associated with the booking
        }

        // Auxiliary methods
        public int calculatePrice()
        {
            // Returns the total cost of the booking (taking in account the possible discount code)
        }
    }
}
