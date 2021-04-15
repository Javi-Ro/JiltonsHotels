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
        private int id;

        private ENUser _user;
        public ENUser user
        {
            get { return _user; }
            private set { _user = value; }
        }

        private ENDate _date;
        public ENDate date
        {
            get { return _date; }
            private set { _date = value; }
        }

        private bool _breakfast;  // It can change, by the moment the attribute is reflected here
        public bool breakfast
        {
            get { return _breakfast; }
            private set { _breakfast = value; }
        }

        // Booking methods
        public Booking(ENUser user, ENDate date, ENRoom rooms[], bool breakfast)
        {

        }

        public bool makeBooking()
        {

        }

        public bool deleteBooking()
        {

        }

        public bool updateBreakfast(bool breakfast)
        {

        }

        // Rooms methods
        const public ENRoom[] getRooms()
        {

        }

        public bool addRoom(ENRoom room)
        {

        }

        public bool deleteRoom(ENRoom room)
        {

        }

        public bool isRoom(ENRoom room)
        {

        }
        
        // Services methods
        const public ENService[] getServices()
        {

        }

        public bool addService(ENService service)
        {

        }

        public bool cancelService(ENService service)
        {

        }

        // Discounts
        public bool applyDiscount(ENDiscount discount)
        {

        }

        public bool quitDiscount(ENDiscount discount)
        {

        }

        // Auxiliary methods
        const public int calculatePrice()
        {

        }
    }
}
