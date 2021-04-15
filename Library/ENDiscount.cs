using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class ENDiscount
    {
        private string _code;
        public string code
        {
            get { return _code; }
            set { _code = value; }
        }

        private int _percentage;
        public int percentage
        {
            get { return _percentage; }
            private set { _percentage = value; }
        }


        public ENDiscount(int code, int percentage)
        {

        }

        public bool createDiscount()
        {

        }

        public bool deleteDiscount()
        {

        }

        public bool updatePercentage(int percentage)
        {

        }

        const public ENBooking[] getBookings()
        {

        }


    }
}
