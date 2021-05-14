﻿using System;
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


        public ENDiscount(string code, int percentage)
        {
            this.code = code;
            this.percentage = percentage;

        }

        public bool createDiscount()
        {
            CADDiscount p = new CADDiscount();
            return p.createDiscount(this);
        }

        public bool deleteDiscount()
        {
            CADDiscount p = new CADDiscount();
            return p.deleteDiscount(this);
        }

        public bool updatePercentage(int percentage)
        {
            CADDiscount p = new CADDiscount();
            return p.updatePercentage(this);
        }
        /*
        const public ENBooking[] getBookings()
        {

        }*/


    }
}
