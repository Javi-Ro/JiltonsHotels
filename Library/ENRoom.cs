using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class ENRoom
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _type;
        public string type
        {
            get { return _type; }
            private set { _type = value; }
        }

        private int _price;
        public int price
        {
            get { return _price; }
            set { _price = value; }
        }

        public ENRoom(int price, int type)
        {

        }

        public bool createRoom()
        {

        }

        public bool deleteRoom()
        {

        }

        public bool updateType(string type)
        {

        }

        public bool updatePrice(int price)
        {

        }

        const public ENBooking[] getBookings()
        {

        }


    }
}
